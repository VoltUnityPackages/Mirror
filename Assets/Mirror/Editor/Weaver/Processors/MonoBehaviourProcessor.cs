using Mono.Cecil;

namespace Mirror.Editor.Weaver.Processors
{
    /// <summary>
    /// only shows warnings in case we use SyncVars etc. for MonoBehaviour.
    /// </summary>
    static class MonoBehaviourProcessor
    {
        public static void Process(TypeDefinition td)
        {
            ProcessSyncVars(td);
            ProcessMethods(td);
        }

        static void ProcessSyncVars(TypeDefinition td)
        {
            // find syncvars
            foreach (FieldDefinition fd in td.Fields)
            {
                if (fd.HasCustomAttribute<SyncVarAttribute>())
                    Editor.Weaver.Weaver.Error($"SyncVar {fd.Name} must be inside a NetworkBehaviour.  {td.Name} is not a NetworkBehaviour", fd);

                if (SyncObjectInitializer.ImplementsSyncObject(fd.FieldType))
                {
                    Editor.Weaver.Weaver.Error($"{fd.Name} is a SyncObject and must be inside a NetworkBehaviour.  {td.Name} is not a NetworkBehaviour", fd);
                }
            }
        }

        static void ProcessMethods(TypeDefinition td)
        {
            // find command and RPC functions
            foreach (MethodDefinition md in td.Methods)
            {
                if (md.HasCustomAttribute<CommandAttribute>())
                    Editor.Weaver.Weaver.Error($"Command {md.Name} must be declared inside a NetworkBehaviour", md);
                if (md.HasCustomAttribute<ClientRpcAttribute>())
                    Editor.Weaver.Weaver.Error($"ClientRpc {md.Name} must be declared inside a NetworkBehaviour", md);
                if (md.HasCustomAttribute<TargetRpcAttribute>())
                    Editor.Weaver.Weaver.Error($"TargetRpc {md.Name} must be declared inside a NetworkBehaviour", md);
            }
        }
    }
}

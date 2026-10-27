using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000C4 RID: 196
	[UnrealObjectPath("/Engine/PythonTypes.USDScriptedSceneExporter")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UUSDScriptedSceneExporter : UExporter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001127 RID: 4391 RVA: 0x00019852 File Offset: 0x00017A52
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUSDScriptedSceneExporter._ClassPtr;
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x00019860 File Offset: 0x00017A60
		public UUSDScriptedSceneExporter() : this(BuiltinUtils.AllocNativeUObject(UUSDScriptedSceneExporter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x00019888 File Offset: 0x00017A88
		[NullableContext(1)]
		public UUSDScriptedSceneExporter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUSDScriptedSceneExporter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x000198BB File Offset: 0x00017ABB
		static UUSDScriptedSceneExporter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Engine/PythonTypes.USDScriptedSceneExporter");
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x000198C9 File Offset: 0x00017AC9
		protected UUSDScriptedSceneExporter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000265 RID: 613
		[Nullable(1)]
		public new const string __ObjectPath = "/Engine/PythonTypes.USDScriptedSceneExporter";

		// Token: 0x04000266 RID: 614
		private static IntPtr _ClassPtr;

		// Token: 0x04000267 RID: 615
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

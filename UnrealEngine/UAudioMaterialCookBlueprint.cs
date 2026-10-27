using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000371 RID: 881
	[UnrealObjectPath("/Script/AudioMaterialPlugin.AudioMaterialCookBlueprint")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UAudioMaterialCookBlueprint : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600305A RID: 12378 RVA: 0x0004AE44 File Offset: 0x00049044
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAudioMaterialCookBlueprint._ClassPtr;
		}

		// Token: 0x0600305B RID: 12379 RVA: 0x0004AE50 File Offset: 0x00049050
		public UAudioMaterialCookBlueprint() : this(BuiltinUtils.AllocNativeUObject(UAudioMaterialCookBlueprint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600305C RID: 12380 RVA: 0x0004AE78 File Offset: 0x00049078
		[NullableContext(1)]
		public UAudioMaterialCookBlueprint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAudioMaterialCookBlueprint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600305D RID: 12381 RVA: 0x0004AEAB File Offset: 0x000490AB
		static UAudioMaterialCookBlueprint()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioMaterialPlugin.AudioMaterialCookBlueprint");
		}

		// Token: 0x0600305E RID: 12382 RVA: 0x0004AEB9 File Offset: 0x000490B9
		protected UAudioMaterialCookBlueprint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001514 RID: 5396
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AudioMaterialPlugin.AudioMaterialCookBlueprint";

		// Token: 0x04001515 RID: 5397
		private static IntPtr _ClassPtr;

		// Token: 0x04001516 RID: 5398
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016C4 RID: 5828
	[UnrealObjectPath("/Script/KuroBulletCore.ActionUpdateTimeScale")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UActionUpdateTimeScale : UBulletActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060151AC RID: 86444 RVA: 0x001F07D2 File Offset: 0x001EE9D2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActionUpdateTimeScale._ClassPtr;
		}

		// Token: 0x060151AD RID: 86445 RVA: 0x001F07E0 File Offset: 0x001EE9E0
		public UActionUpdateTimeScale() : this(BuiltinUtils.AllocNativeUObject(UActionUpdateTimeScale.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060151AE RID: 86446 RVA: 0x001F0808 File Offset: 0x001EEA08
		[NullableContext(1)]
		public UActionUpdateTimeScale(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActionUpdateTimeScale.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060151AF RID: 86447 RVA: 0x001F083B File Offset: 0x001EEA3B
		static UActionUpdateTimeScale()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.ActionUpdateTimeScale");
		}

		// Token: 0x060151B0 RID: 86448 RVA: 0x001F0849 File Offset: 0x001EEA49
		protected UActionUpdateTimeScale(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B7C6 RID: 47046
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.ActionUpdateTimeScale";

		// Token: 0x0400B7C7 RID: 47047
		private static IntPtr _ClassPtr;

		// Token: 0x0400B7C8 RID: 47048
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

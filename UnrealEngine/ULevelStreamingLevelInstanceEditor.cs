using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D3C RID: 3388
	[UnrealObjectPath("/Script/Engine.LevelStreamingLevelInstanceEditor")]
	[UnrealStructLayout(592, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 592)]
	public class ULevelStreamingLevelInstanceEditor : ULevelStreamingAlwaysLoaded, IUnrealUObject, IUnrealObject, ILevelInstanceLevelStreamingInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0600B5A0 RID: 46496 RVA: 0x001031CA File Offset: 0x001013CA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULevelStreamingLevelInstanceEditor._ClassPtr;
		}

		// Token: 0x0600B5A1 RID: 46497 RVA: 0x001031D6 File Offset: 0x001013D6
		int ILevelInstanceLevelStreamingInterface.InterfaceOffset()
		{
			return ULevelStreamingLevelInstanceEditor.__InterfaceOffset_ILevelInstanceLevelStreamingInterface;
		}

		// Token: 0x0600B5A2 RID: 46498 RVA: 0x001031E0 File Offset: 0x001013E0
		public ULevelStreamingLevelInstanceEditor() : this(BuiltinUtils.AllocNativeUObject(ULevelStreamingLevelInstanceEditor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B5A3 RID: 46499 RVA: 0x00103208 File Offset: 0x00101408
		[NullableContext(1)]
		public ULevelStreamingLevelInstanceEditor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULevelStreamingLevelInstanceEditor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B5A4 RID: 46500 RVA: 0x0010323B File Offset: 0x0010143B
		static ULevelStreamingLevelInstanceEditor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LevelStreamingLevelInstanceEditor");
		}

		// Token: 0x0600B5A5 RID: 46501 RVA: 0x00103249 File Offset: 0x00101449
		protected ULevelStreamingLevelInstanceEditor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005F75 RID: 24437
		internal static int __InterfaceOffset_ILevelInstanceLevelStreamingInterface;

		// Token: 0x04005F76 RID: 24438
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LevelStreamingLevelInstanceEditor";

		// Token: 0x04005F77 RID: 24439
		private static IntPtr _ClassPtr;

		// Token: 0x04005F78 RID: 24440
		private static IntPtr _ClassDefaultObjectPtr;
	}
}

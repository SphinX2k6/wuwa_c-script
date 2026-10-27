using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021CC RID: 8652
	[UnrealObjectPath("/Script/LGUI.UITextClickComponent")]
	[UnrealStructLayout(368, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 368)]
	public class UUITextClickComponent : ULGUIBehaviour, IUnrealUObject, IUnrealObject, ILGUIPointerEnterExitInterface, IUnrealNativeInterface, IUnrealInterface, ILGUIPointerClickInterface
	{
		// Token: 0x06020F59 RID: 135001 RVA: 0x0030A3B1 File Offset: 0x003085B1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUITextClickComponent._ClassPtr;
		}

		// Token: 0x06020F5A RID: 135002 RVA: 0x0030A3BD File Offset: 0x003085BD
		int ILGUIPointerEnterExitInterface.InterfaceOffset()
		{
			return UUITextClickComponent.__InterfaceOffset_ILGUIPointerEnterExitInterface;
		}

		// Token: 0x06020F5B RID: 135003 RVA: 0x0030A3C4 File Offset: 0x003085C4
		int ILGUIPointerClickInterface.InterfaceOffset()
		{
			return UUITextClickComponent.__InterfaceOffset_ILGUIPointerClickInterface;
		}

		// Token: 0x06020F5C RID: 135004 RVA: 0x0030A3CC File Offset: 0x003085CC
		public UUITextClickComponent() : this(BuiltinUtils.AllocNativeUObject(UUITextClickComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020F5D RID: 135005 RVA: 0x0030A3F4 File Offset: 0x003085F4
		[NullableContext(1)]
		public UUITextClickComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUITextClickComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170080A9 RID: 32937
		// (get) Token: 0x06020F5E RID: 135006 RVA: 0x0030A427 File Offset: 0x00308627
		// (set) Token: 0x06020F5F RID: 135007 RVA: 0x0030A43B File Offset: 0x0030863B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUIText> Target
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUITextClickComponent.__PropertyOffset_Target);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUITextClickComponent.__PropertyOffset_Target) = value;
			}
		}

		// Token: 0x06020F60 RID: 135008 RVA: 0x0030A450 File Offset: 0x00308650
		static UUITextClickComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UITextClickComponent");
		}

		// Token: 0x06020F61 RID: 135009 RVA: 0x0030A45E File Offset: 0x0030865E
		protected UUITextClickComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401196F RID: 72047
		internal static int __InterfaceOffset_ILGUIPointerEnterExitInterface;

		// Token: 0x04011970 RID: 72048
		internal static int __InterfaceOffset_ILGUIPointerClickInterface;

		// Token: 0x04011971 RID: 72049
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UITextClickComponent";

		// Token: 0x04011972 RID: 72050
		private static IntPtr _ClassPtr;

		// Token: 0x04011973 RID: 72051
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011974 RID: 72052
		internal static int __PropertyOffset_Target;
	}
}

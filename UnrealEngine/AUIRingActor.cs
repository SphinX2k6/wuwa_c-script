using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200219E RID: 8606
	[UnrealObjectPath("/Script/LGUI.UIRingActor")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class AUIRingActor : AUIBaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020A49 RID: 133705 RVA: 0x00304E49 File Offset: 0x00303049
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AUIRingActor._ClassPtr;
		}

		// Token: 0x06020A4A RID: 133706 RVA: 0x00304E58 File Offset: 0x00303058
		public AUIRingActor() : this(BuiltinUtils.AllocNativeUObject(AUIRingActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020A4B RID: 133707 RVA: 0x00304E80 File Offset: 0x00303080
		[NullableContext(1)]
		public AUIRingActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AUIRingActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007F97 RID: 32663
		// (get) Token: 0x06020A4C RID: 133708 RVA: 0x00304EB3 File Offset: 0x003030B3
		// (set) Token: 0x06020A4D RID: 133709 RVA: 0x00304EC7 File Offset: 0x003030C7
		[Nullable(2)]
		public unsafe UUIRing UIElement
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIRing>(base.NativePtr / (IntPtr)sizeof(void*) + AUIRingActor.__PropertyOffset_UIElement);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AUIRingActor.__PropertyOffset_UIElement, value);
			}
		}

		// Token: 0x06020A4E RID: 133710 RVA: 0x00304EDC File Offset: 0x003030DC
		static AUIRingActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIRingActor");
		}

		// Token: 0x06020A4F RID: 133711 RVA: 0x00304EEA File Offset: 0x003030EA
		protected AUIRingActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011775 RID: 71541
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIRingActor";

		// Token: 0x04011776 RID: 71542
		private static IntPtr _ClassPtr;

		// Token: 0x04011777 RID: 71543
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011778 RID: 71544
		internal static int __PropertyOffset_UIElement;
	}
}

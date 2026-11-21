using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006EF RID: 1775
	[UnrealObjectPath("/Script/LGUI.UIContainerActor")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class AUIContainerActor : AUIBaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060096D2 RID: 38610 RVA: 0x000E3851 File Offset: 0x000E1A51
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AUIContainerActor._ClassPtr;
		}

		// Token: 0x060096D3 RID: 38611 RVA: 0x000E3860 File Offset: 0x000E1A60
		public AUIContainerActor() : this(BuiltinUtils.AllocNativeUObject(AUIContainerActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060096D4 RID: 38612 RVA: 0x000E3888 File Offset: 0x000E1A88
		[NullableContext(1)]
		public AUIContainerActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AUIContainerActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001BFF RID: 7167
		// (get) Token: 0x060096D5 RID: 38613 RVA: 0x000E38BB File Offset: 0x000E1ABB
		// (set) Token: 0x060096D6 RID: 38614 RVA: 0x000E38CF File Offset: 0x000E1ACF
		[Nullable(2)]
		public unsafe UUIItem UIItem
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIItem>(base.NativePtr / (IntPtr)sizeof(void*) + AUIContainerActor.__PropertyOffset_UIItem);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AUIContainerActor.__PropertyOffset_UIItem, value);
			}
		}

		// Token: 0x060096D7 RID: 38615 RVA: 0x000E38E4 File Offset: 0x000E1AE4
		static AUIContainerActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIContainerActor");
		}

		// Token: 0x060096D8 RID: 38616 RVA: 0x000E38F2 File Offset: 0x000E1AF2
		protected AUIContainerActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400419B RID: 16795
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIContainerActor";

		// Token: 0x0400419C RID: 16796
		private static IntPtr _ClassPtr;

		// Token: 0x0400419D RID: 16797
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400419E RID: 16798
		internal static int __PropertyOffset_UIItem;
	}
}

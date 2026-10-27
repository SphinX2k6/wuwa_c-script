using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200153E RID: 5438
	[UnrealObjectPath("/Script/InteractiveToolsFramework.ClickDragInputBehavior")]
	[UnrealStructLayout(352, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 352)]
	public class UClickDragInputBehavior : UAnyButtonInputBehavior, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013BEE RID: 80878 RVA: 0x001CFE66 File Offset: 0x001CE066
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UClickDragInputBehavior._ClassPtr;
		}

		// Token: 0x06013BEF RID: 80879 RVA: 0x001CFE74 File Offset: 0x001CE074
		public UClickDragInputBehavior() : this(BuiltinUtils.AllocNativeUObject(UClickDragInputBehavior.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013BF0 RID: 80880 RVA: 0x001CFE9C File Offset: 0x001CE09C
		[NullableContext(1)]
		public UClickDragInputBehavior(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UClickDragInputBehavior.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D5A RID: 19802
		// (get) Token: 0x06013BF1 RID: 80881 RVA: 0x001CFECF File Offset: 0x001CE0CF
		// (set) Token: 0x06013BF2 RID: 80882 RVA: 0x001CFEDF File Offset: 0x001CE0DF
		public unsafe bool bUpdateModifiersDuringDrag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UClickDragInputBehavior.__PropertyOffset_bUpdateModifiersDuringDrag) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UClickDragInputBehavior.__PropertyOffset_bUpdateModifiersDuringDrag) = (value ? 1 : 0);
			}
		}

		// Token: 0x06013BF3 RID: 80883 RVA: 0x001CFEF0 File Offset: 0x001CE0F0
		static UClickDragInputBehavior()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.ClickDragInputBehavior");
		}

		// Token: 0x06013BF4 RID: 80884 RVA: 0x001CFEFE File Offset: 0x001CE0FE
		protected UClickDragInputBehavior(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AAE2 RID: 43746
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.ClickDragInputBehavior";

		// Token: 0x0400AAE3 RID: 43747
		private static IntPtr _ClassPtr;

		// Token: 0x0400AAE4 RID: 43748
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AAE5 RID: 43749
		internal static int __PropertyOffset_bUpdateModifiersDuringDrag;
	}
}

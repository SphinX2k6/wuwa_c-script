using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006AF RID: 1711
	[UnrealObjectPath("/Script/LGUI.LGUIPlayTween_Vector2")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class ULGUIPlayTween_Vector2 : ULGUIPlayTween, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060092DF RID: 37599 RVA: 0x000DD36C File Offset: 0x000DB56C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIPlayTween_Vector2._ClassPtr;
		}

		// Token: 0x060092E0 RID: 37600 RVA: 0x000DD378 File Offset: 0x000DB578
		public ULGUIPlayTween_Vector2() : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTween_Vector2.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060092E1 RID: 37601 RVA: 0x000DD3A0 File Offset: 0x000DB5A0
		[NullableContext(1)]
		public ULGUIPlayTween_Vector2(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTween_Vector2.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B62 RID: 7010
		// (get) Token: 0x060092E2 RID: 37602 RVA: 0x000DD3D3 File Offset: 0x000DB5D3
		// (set) Token: 0x060092E3 RID: 37603 RVA: 0x000DD3E7 File Offset: 0x000DB5E7
		public unsafe FVector2D from
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween_Vector2.__PropertyOffset_from);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween_Vector2.__PropertyOffset_from) = value;
			}
		}

		// Token: 0x17001B63 RID: 7011
		// (get) Token: 0x060092E4 RID: 37604 RVA: 0x000DD3FC File Offset: 0x000DB5FC
		// (set) Token: 0x060092E5 RID: 37605 RVA: 0x000DD410 File Offset: 0x000DB610
		public unsafe FVector2D to
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween_Vector2.__PropertyOffset_to);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween_Vector2.__PropertyOffset_to) = value;
			}
		}

		// Token: 0x060092E6 RID: 37606 RVA: 0x000DD425 File Offset: 0x000DB625
		static ULGUIPlayTween_Vector2()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIPlayTween_Vector2");
		}

		// Token: 0x060092E7 RID: 37607 RVA: 0x000DD433 File Offset: 0x000DB633
		protected ULGUIPlayTween_Vector2(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004004 RID: 16388
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIPlayTween_Vector2";

		// Token: 0x04004005 RID: 16389
		private static IntPtr _ClassPtr;

		// Token: 0x04004006 RID: 16390
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004007 RID: 16391
		internal static int __PropertyOffset_from;

		// Token: 0x04004008 RID: 16392
		internal static int __PropertyOffset_to;
	}
}

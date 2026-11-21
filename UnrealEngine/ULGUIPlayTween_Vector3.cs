using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006B0 RID: 1712
	[UnrealObjectPath("/Script/LGUI.LGUIPlayTween_Vector3")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class ULGUIPlayTween_Vector3 : ULGUIPlayTween, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060092E8 RID: 37608 RVA: 0x000DD43C File Offset: 0x000DB63C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIPlayTween_Vector3._ClassPtr;
		}

		// Token: 0x060092E9 RID: 37609 RVA: 0x000DD448 File Offset: 0x000DB648
		public ULGUIPlayTween_Vector3() : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTween_Vector3.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060092EA RID: 37610 RVA: 0x000DD470 File Offset: 0x000DB670
		[NullableContext(1)]
		public ULGUIPlayTween_Vector3(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTween_Vector3.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B64 RID: 7012
		// (get) Token: 0x060092EB RID: 37611 RVA: 0x000DD4A3 File Offset: 0x000DB6A3
		// (set) Token: 0x060092EC RID: 37612 RVA: 0x000DD4B7 File Offset: 0x000DB6B7
		public unsafe FVector from
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween_Vector3.__PropertyOffset_from);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween_Vector3.__PropertyOffset_from) = value;
			}
		}

		// Token: 0x17001B65 RID: 7013
		// (get) Token: 0x060092ED RID: 37613 RVA: 0x000DD4CC File Offset: 0x000DB6CC
		// (set) Token: 0x060092EE RID: 37614 RVA: 0x000DD4E0 File Offset: 0x000DB6E0
		public unsafe FVector to
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween_Vector3.__PropertyOffset_to);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween_Vector3.__PropertyOffset_to) = value;
			}
		}

		// Token: 0x060092EF RID: 37615 RVA: 0x000DD4F5 File Offset: 0x000DB6F5
		static ULGUIPlayTween_Vector3()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIPlayTween_Vector3");
		}

		// Token: 0x060092F0 RID: 37616 RVA: 0x000DD503 File Offset: 0x000DB703
		protected ULGUIPlayTween_Vector3(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004009 RID: 16393
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIPlayTween_Vector3";

		// Token: 0x0400400A RID: 16394
		private static IntPtr _ClassPtr;

		// Token: 0x0400400B RID: 16395
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400400C RID: 16396
		internal static int __PropertyOffset_from;

		// Token: 0x0400400D RID: 16397
		internal static int __PropertyOffset_to;
	}
}

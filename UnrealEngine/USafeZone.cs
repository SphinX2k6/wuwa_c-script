using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029CC RID: 10700
	[UnrealObjectPath("/Script/UMG.SafeZone")]
	[UnrealStructLayout(728, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 728)]
	public class USafeZone : UContentWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060278E3 RID: 162019 RVA: 0x003C59D7 File Offset: 0x003C3BD7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USafeZone._ClassPtr;
		}

		// Token: 0x060278E4 RID: 162020 RVA: 0x003C59E4 File Offset: 0x003C3BE4
		public USafeZone() : this(BuiltinUtils.AllocNativeUObject(USafeZone.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060278E5 RID: 162021 RVA: 0x003C5A0C File Offset: 0x003C3C0C
		[NullableContext(1)]
		public USafeZone(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USafeZone.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009791 RID: 38801
		// (get) Token: 0x060278E6 RID: 162022 RVA: 0x003C5A3F File Offset: 0x003C3C3F
		// (set) Token: 0x060278E7 RID: 162023 RVA: 0x003C5A4F File Offset: 0x003C3C4F
		public unsafe bool PadLeft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USafeZone.__PropertyOffset_PadLeft) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USafeZone.__PropertyOffset_PadLeft) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009792 RID: 38802
		// (get) Token: 0x060278E8 RID: 162024 RVA: 0x003C5A60 File Offset: 0x003C3C60
		// (set) Token: 0x060278E9 RID: 162025 RVA: 0x003C5A70 File Offset: 0x003C3C70
		public unsafe bool PadRight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USafeZone.__PropertyOffset_PadRight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USafeZone.__PropertyOffset_PadRight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009793 RID: 38803
		// (get) Token: 0x060278EA RID: 162026 RVA: 0x003C5A81 File Offset: 0x003C3C81
		// (set) Token: 0x060278EB RID: 162027 RVA: 0x003C5A91 File Offset: 0x003C3C91
		public unsafe bool PadTop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USafeZone.__PropertyOffset_PadTop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USafeZone.__PropertyOffset_PadTop) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009794 RID: 38804
		// (get) Token: 0x060278EC RID: 162028 RVA: 0x003C5AA2 File Offset: 0x003C3CA2
		// (set) Token: 0x060278ED RID: 162029 RVA: 0x003C5AB2 File Offset: 0x003C3CB2
		public unsafe bool PadBottom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USafeZone.__PropertyOffset_PadBottom) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USafeZone.__PropertyOffset_PadBottom) = (value ? 1 : 0);
			}
		}

		// Token: 0x060278EE RID: 162030 RVA: 0x003C5AC3 File Offset: 0x003C3CC3
		public void SetSidesToPad(bool InPadLeft, bool InPadRight, bool InPadTop, bool InPadBottom)
		{
			USafeZone.__SetSidesToPad_Internal(base.NativePtr, InPadLeft, InPadRight, InPadTop, InPadBottom);
		}

		// Token: 0x060278EF RID: 162031
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSidesToPad_Internal(IntPtr @this, bool InPadLeft, bool InPadRight, bool InPadTop, bool InPadBottom);

		// Token: 0x060278F0 RID: 162032 RVA: 0x003C5AD5 File Offset: 0x003C3CD5
		static USafeZone()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.SafeZone");
		}

		// Token: 0x060278F1 RID: 162033 RVA: 0x003C5AE3 File Offset: 0x003C3CE3
		protected USafeZone(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015AEB RID: 88811
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.SafeZone";

		// Token: 0x04015AEC RID: 88812
		private static IntPtr _ClassPtr;

		// Token: 0x04015AED RID: 88813
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015AEE RID: 88814
		internal static int __PropertyOffset_PadLeft;

		// Token: 0x04015AEF RID: 88815
		internal static int __PropertyOffset_PadRight;

		// Token: 0x04015AF0 RID: 88816
		internal static int __PropertyOffset_PadTop;

		// Token: 0x04015AF1 RID: 88817
		internal static int __PropertyOffset_PadBottom;
	}
}

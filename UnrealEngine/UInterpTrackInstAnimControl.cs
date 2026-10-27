using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C98 RID: 3224
	[UnrealObjectPath("/Script/Engine.InterpTrackInstAnimControl")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UInterpTrackInstAnimControl : UInterpTrackInst, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A37C RID: 41852 RVA: 0x000E85CA File Offset: 0x000E67CA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackInstAnimControl._ClassPtr;
		}

		// Token: 0x0600A37D RID: 41853 RVA: 0x000E85D8 File Offset: 0x000E67D8
		public UInterpTrackInstAnimControl() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstAnimControl.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A37E RID: 41854 RVA: 0x000E8600 File Offset: 0x000E6800
		[NullableContext(1)]
		public UInterpTrackInstAnimControl(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstAnimControl.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026EA RID: 9962
		// (get) Token: 0x0600A37F RID: 41855 RVA: 0x000E8633 File Offset: 0x000E6833
		// (set) Token: 0x0600A380 RID: 41856 RVA: 0x000E8643 File Offset: 0x000E6843
		public unsafe float LastUpdatePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackInstAnimControl.__PropertyOffset_LastUpdatePosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackInstAnimControl.__PropertyOffset_LastUpdatePosition) = value;
			}
		}

		// Token: 0x0600A381 RID: 41857 RVA: 0x000E8654 File Offset: 0x000E6854
		static UInterpTrackInstAnimControl()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackInstAnimControl");
		}

		// Token: 0x0600A382 RID: 41858 RVA: 0x000E8662 File Offset: 0x000E6862
		protected UInterpTrackInstAnimControl(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040059D7 RID: 22999
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackInstAnimControl";

		// Token: 0x040059D8 RID: 23000
		private static IntPtr _ClassPtr;

		// Token: 0x040059D9 RID: 23001
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040059DA RID: 23002
		internal static int __PropertyOffset_LastUpdatePosition;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CB9 RID: 3257
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InterpTrackVisibility")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UInterpTrackVisibility : UInterpTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A4A7 RID: 42151 RVA: 0x000EA4B7 File Offset: 0x000E86B7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackVisibility._ClassPtr;
		}

		// Token: 0x0600A4A8 RID: 42152 RVA: 0x000EA4C4 File Offset: 0x000E86C4
		public UInterpTrackVisibility() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackVisibility.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A4A9 RID: 42153 RVA: 0x000EA4EC File Offset: 0x000E86EC
		public UInterpTrackVisibility(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackVisibility.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700272E RID: 10030
		// (get) Token: 0x0600A4AA RID: 42154 RVA: 0x000EA520 File Offset: 0x000E8720
		// (set) Token: 0x0600A4AB RID: 42155 RVA: 0x000EA559 File Offset: 0x000E8759
		public TArray<FVisibilityTrackKey> VisibilityTrack
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVisibilityTrackKey> result;
				if ((result = this._VisibilityTrack) == null)
				{
					result = (this._VisibilityTrack = new TArray<FVisibilityTrackKey>(base.NativePtr + (IntPtr)UInterpTrackVisibility.__PropertyOffset_VisibilityTrack, this));
				}
				return result;
			}
			set
			{
				this.VisibilityTrack.CopyAssign(value);
			}
		}

		// Token: 0x1700272F RID: 10031
		// (get) Token: 0x0600A4AC RID: 42156 RVA: 0x000EA567 File Offset: 0x000E8767
		// (set) Token: 0x0600A4AD RID: 42157 RVA: 0x000EA580 File Offset: 0x000E8780
		public unsafe bool bFireEventsWhenForwards
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrackVisibility.__PropertyOffset_bFireEventsWhenForwards) & UInterpTrackVisibility.__PropertyMask_bFireEventsWhenForwards) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrackVisibility.__PropertyOffset_bFireEventsWhenForwards) = ((*(base.NativePtr + (IntPtr)UInterpTrackVisibility.__PropertyOffset_bFireEventsWhenForwards) & ~UInterpTrackVisibility.__PropertyMask_bFireEventsWhenForwards) | (value ? UInterpTrackVisibility.__PropertyMask_bFireEventsWhenForwards : 0));
			}
		}

		// Token: 0x17002730 RID: 10032
		// (get) Token: 0x0600A4AE RID: 42158 RVA: 0x000EA5B0 File Offset: 0x000E87B0
		// (set) Token: 0x0600A4AF RID: 42159 RVA: 0x000EA5C9 File Offset: 0x000E87C9
		public unsafe bool bFireEventsWhenBackwards
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrackVisibility.__PropertyOffset_bFireEventsWhenBackwards) & UInterpTrackVisibility.__PropertyMask_bFireEventsWhenBackwards) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrackVisibility.__PropertyOffset_bFireEventsWhenBackwards) = ((*(base.NativePtr + (IntPtr)UInterpTrackVisibility.__PropertyOffset_bFireEventsWhenBackwards) & ~UInterpTrackVisibility.__PropertyMask_bFireEventsWhenBackwards) | (value ? UInterpTrackVisibility.__PropertyMask_bFireEventsWhenBackwards : 0));
			}
		}

		// Token: 0x17002731 RID: 10033
		// (get) Token: 0x0600A4B0 RID: 42160 RVA: 0x000EA5F9 File Offset: 0x000E87F9
		// (set) Token: 0x0600A4B1 RID: 42161 RVA: 0x000EA612 File Offset: 0x000E8812
		public unsafe bool bFireEventsWhenJumpingForwards
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrackVisibility.__PropertyOffset_bFireEventsWhenJumpingForwards) & UInterpTrackVisibility.__PropertyMask_bFireEventsWhenJumpingForwards) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrackVisibility.__PropertyOffset_bFireEventsWhenJumpingForwards) = ((*(base.NativePtr + (IntPtr)UInterpTrackVisibility.__PropertyOffset_bFireEventsWhenJumpingForwards) & ~UInterpTrackVisibility.__PropertyMask_bFireEventsWhenJumpingForwards) | (value ? UInterpTrackVisibility.__PropertyMask_bFireEventsWhenJumpingForwards : 0));
			}
		}

		// Token: 0x0600A4B2 RID: 42162 RVA: 0x000EA642 File Offset: 0x000E8842
		static UInterpTrackVisibility()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackVisibility");
		}

		// Token: 0x0600A4B3 RID: 42163 RVA: 0x000EA650 File Offset: 0x000E8850
		protected UInterpTrackVisibility(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005A9F RID: 23199
		public new const string __ObjectPath = "/Script/Engine.InterpTrackVisibility";

		// Token: 0x04005AA0 RID: 23200
		private static IntPtr _ClassPtr;

		// Token: 0x04005AA1 RID: 23201
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005AA2 RID: 23202
		internal static int __PropertyOffset_VisibilityTrack;

		// Token: 0x04005AA3 RID: 23203
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FVisibilityTrackKey> _VisibilityTrack;

		// Token: 0x04005AA4 RID: 23204
		internal static int __PropertyOffset_bFireEventsWhenForwards;

		// Token: 0x04005AA5 RID: 23205
		internal static byte __PropertyMask_bFireEventsWhenForwards;

		// Token: 0x04005AA6 RID: 23206
		internal static int __PropertyOffset_bFireEventsWhenBackwards;

		// Token: 0x04005AA7 RID: 23207
		internal static byte __PropertyMask_bFireEventsWhenBackwards;

		// Token: 0x04005AA8 RID: 23208
		internal static int __PropertyOffset_bFireEventsWhenJumpingForwards;

		// Token: 0x04005AA9 RID: 23209
		internal static byte __PropertyMask_bFireEventsWhenJumpingForwards;
	}
}

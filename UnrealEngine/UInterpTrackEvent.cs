using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C90 RID: 3216
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InterpTrackEvent")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UInterpTrackEvent : UInterpTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A333 RID: 41779 RVA: 0x000E7E1B File Offset: 0x000E601B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackEvent._ClassPtr;
		}

		// Token: 0x0600A334 RID: 41780 RVA: 0x000E7E28 File Offset: 0x000E6028
		public UInterpTrackEvent() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A335 RID: 41781 RVA: 0x000E7E50 File Offset: 0x000E6050
		public UInterpTrackEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026D9 RID: 9945
		// (get) Token: 0x0600A336 RID: 41782 RVA: 0x000E7E84 File Offset: 0x000E6084
		// (set) Token: 0x0600A337 RID: 41783 RVA: 0x000E7EBD File Offset: 0x000E60BD
		public TArray<FEventTrackKey> EventTrack
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FEventTrackKey> result;
				if ((result = this._EventTrack) == null)
				{
					result = (this._EventTrack = new TArray<FEventTrackKey>(base.NativePtr + (IntPtr)UInterpTrackEvent.__PropertyOffset_EventTrack, this));
				}
				return result;
			}
			set
			{
				this.EventTrack.CopyAssign(value);
			}
		}

		// Token: 0x170026DA RID: 9946
		// (get) Token: 0x0600A338 RID: 41784 RVA: 0x000E7ECB File Offset: 0x000E60CB
		// (set) Token: 0x0600A339 RID: 41785 RVA: 0x000E7EE4 File Offset: 0x000E60E4
		public unsafe bool bFireEventsWhenForwards
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrackEvent.__PropertyOffset_bFireEventsWhenForwards) & UInterpTrackEvent.__PropertyMask_bFireEventsWhenForwards) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrackEvent.__PropertyOffset_bFireEventsWhenForwards) = ((*(base.NativePtr + (IntPtr)UInterpTrackEvent.__PropertyOffset_bFireEventsWhenForwards) & ~UInterpTrackEvent.__PropertyMask_bFireEventsWhenForwards) | (value ? UInterpTrackEvent.__PropertyMask_bFireEventsWhenForwards : 0));
			}
		}

		// Token: 0x170026DB RID: 9947
		// (get) Token: 0x0600A33A RID: 41786 RVA: 0x000E7F14 File Offset: 0x000E6114
		// (set) Token: 0x0600A33B RID: 41787 RVA: 0x000E7F2D File Offset: 0x000E612D
		public unsafe bool bFireEventsWhenBackwards
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrackEvent.__PropertyOffset_bFireEventsWhenBackwards) & UInterpTrackEvent.__PropertyMask_bFireEventsWhenBackwards) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrackEvent.__PropertyOffset_bFireEventsWhenBackwards) = ((*(base.NativePtr + (IntPtr)UInterpTrackEvent.__PropertyOffset_bFireEventsWhenBackwards) & ~UInterpTrackEvent.__PropertyMask_bFireEventsWhenBackwards) | (value ? UInterpTrackEvent.__PropertyMask_bFireEventsWhenBackwards : 0));
			}
		}

		// Token: 0x170026DC RID: 9948
		// (get) Token: 0x0600A33C RID: 41788 RVA: 0x000E7F5D File Offset: 0x000E615D
		// (set) Token: 0x0600A33D RID: 41789 RVA: 0x000E7F76 File Offset: 0x000E6176
		public unsafe bool bFireEventsWhenJumpingForwards
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrackEvent.__PropertyOffset_bFireEventsWhenJumpingForwards) & UInterpTrackEvent.__PropertyMask_bFireEventsWhenJumpingForwards) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrackEvent.__PropertyOffset_bFireEventsWhenJumpingForwards) = ((*(base.NativePtr + (IntPtr)UInterpTrackEvent.__PropertyOffset_bFireEventsWhenJumpingForwards) & ~UInterpTrackEvent.__PropertyMask_bFireEventsWhenJumpingForwards) | (value ? UInterpTrackEvent.__PropertyMask_bFireEventsWhenJumpingForwards : 0));
			}
		}

		// Token: 0x170026DD RID: 9949
		// (get) Token: 0x0600A33E RID: 41790 RVA: 0x000E7FA6 File Offset: 0x000E61A6
		// (set) Token: 0x0600A33F RID: 41791 RVA: 0x000E7FBF File Offset: 0x000E61BF
		public unsafe bool bUseCustomEventName
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrackEvent.__PropertyOffset_bUseCustomEventName) & UInterpTrackEvent.__PropertyMask_bUseCustomEventName) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrackEvent.__PropertyOffset_bUseCustomEventName) = ((*(base.NativePtr + (IntPtr)UInterpTrackEvent.__PropertyOffset_bUseCustomEventName) & ~UInterpTrackEvent.__PropertyMask_bUseCustomEventName) | (value ? UInterpTrackEvent.__PropertyMask_bUseCustomEventName : 0));
			}
		}

		// Token: 0x0600A340 RID: 41792 RVA: 0x000E7FEF File Offset: 0x000E61EF
		static UInterpTrackEvent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackEvent");
		}

		// Token: 0x0600A341 RID: 41793 RVA: 0x000E7FFD File Offset: 0x000E61FD
		protected UInterpTrackEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040059A5 RID: 22949
		public new const string __ObjectPath = "/Script/Engine.InterpTrackEvent";

		// Token: 0x040059A6 RID: 22950
		private static IntPtr _ClassPtr;

		// Token: 0x040059A7 RID: 22951
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040059A8 RID: 22952
		internal static int __PropertyOffset_EventTrack;

		// Token: 0x040059A9 RID: 22953
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FEventTrackKey> _EventTrack;

		// Token: 0x040059AA RID: 22954
		internal static int __PropertyOffset_bFireEventsWhenForwards;

		// Token: 0x040059AB RID: 22955
		internal static byte __PropertyMask_bFireEventsWhenForwards;

		// Token: 0x040059AC RID: 22956
		internal static int __PropertyOffset_bFireEventsWhenBackwards;

		// Token: 0x040059AD RID: 22957
		internal static byte __PropertyMask_bFireEventsWhenBackwards;

		// Token: 0x040059AE RID: 22958
		internal static int __PropertyOffset_bFireEventsWhenJumpingForwards;

		// Token: 0x040059AF RID: 22959
		internal static byte __PropertyMask_bFireEventsWhenJumpingForwards;

		// Token: 0x040059B0 RID: 22960
		internal static int __PropertyOffset_bUseCustomEventName;

		// Token: 0x040059B1 RID: 22961
		internal static byte __PropertyMask_bUseCustomEventName;
	}
}

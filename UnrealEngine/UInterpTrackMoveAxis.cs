using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CB1 RID: 3249
	[UnrealObjectPath("/Script/Engine.InterpTrackMoveAxis")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UInterpTrackMoveAxis : UInterpTrackFloatBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A458 RID: 42072 RVA: 0x000E9B9F File Offset: 0x000E7D9F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackMoveAxis._ClassPtr;
		}

		// Token: 0x0600A459 RID: 42073 RVA: 0x000E9BAC File Offset: 0x000E7DAC
		public UInterpTrackMoveAxis() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackMoveAxis.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A45A RID: 42074 RVA: 0x000E9BD4 File Offset: 0x000E7DD4
		[NullableContext(1)]
		public UInterpTrackMoveAxis(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackMoveAxis.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700271A RID: 10010
		// (get) Token: 0x0600A45B RID: 42075 RVA: 0x000E9C07 File Offset: 0x000E7E07
		// (set) Token: 0x0600A45C RID: 42076 RVA: 0x000E9C1B File Offset: 0x000E7E1B
		public unsafe TEnumAsByte<EInterpMoveAxis> MoveAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackMoveAxis.__PropertyOffset_MoveAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackMoveAxis.__PropertyOffset_MoveAxis) = value;
			}
		}

		// Token: 0x1700271B RID: 10011
		// (get) Token: 0x0600A45D RID: 42077 RVA: 0x000E9C30 File Offset: 0x000E7E30
		// (set) Token: 0x0600A45E RID: 42078 RVA: 0x000E9C69 File Offset: 0x000E7E69
		[Nullable(1)]
		public FInterpLookupTrack LookupTrack
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FInterpLookupTrack result;
				if ((result = this._LookupTrack) == null)
				{
					result = (this._LookupTrack = new FInterpLookupTrack(base.NativePtr + (IntPtr)UInterpTrackMoveAxis.__PropertyOffset_LookupTrack, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInterpLookupTrack.StaticStruct(), base.NativePtr + (IntPtr)UInterpTrackMoveAxis.__PropertyOffset_LookupTrack, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600A45F RID: 42079 RVA: 0x000E9C8A File Offset: 0x000E7E8A
		static UInterpTrackMoveAxis()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackMoveAxis");
		}

		// Token: 0x0600A460 RID: 42080 RVA: 0x000E9C98 File Offset: 0x000E7E98
		protected UInterpTrackMoveAxis(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005A63 RID: 23139
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackMoveAxis";

		// Token: 0x04005A64 RID: 23140
		private static IntPtr _ClassPtr;

		// Token: 0x04005A65 RID: 23141
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005A66 RID: 23142
		internal static int __PropertyOffset_MoveAxis;

		// Token: 0x04005A67 RID: 23143
		internal static int __PropertyOffset_LookupTrack;

		// Token: 0x04005A68 RID: 23144
		[Nullable(2)]
		private FInterpLookupTrack _LookupTrack;
	}
}

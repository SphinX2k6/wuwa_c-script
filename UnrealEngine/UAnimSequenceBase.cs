using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200083A RID: 2106
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimSequenceBase")]
	[UnrealStructLayout(440, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 440)]
	public abstract class UAnimSequenceBase : UAnimationAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007164 RID: 29028 RVA: 0x000A2798 File Offset: 0x000A0998
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimSequenceBase._ClassPtr;
		}

		// Token: 0x17001AB6 RID: 6838
		// (get) Token: 0x06007165 RID: 29029 RVA: 0x000A27A4 File Offset: 0x000A09A4
		// (set) Token: 0x06007166 RID: 29030 RVA: 0x000A27DD File Offset: 0x000A09DD
		public TArray<FAnimNotifyEvent> Notifies
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimNotifyEvent> result;
				if ((result = this._Notifies) == null)
				{
					result = (this._Notifies = new TArray<FAnimNotifyEvent>(base.NativePtr + (IntPtr)UAnimSequenceBase.__PropertyOffset_Notifies, this));
				}
				return result;
			}
			set
			{
				this.Notifies.CopyAssign(value);
			}
		}

		// Token: 0x17001AB7 RID: 6839
		// (get) Token: 0x06007167 RID: 29031 RVA: 0x000A27EB File Offset: 0x000A09EB
		// (set) Token: 0x06007168 RID: 29032 RVA: 0x000A27FB File Offset: 0x000A09FB
		public unsafe float SequenceLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequenceBase.__PropertyOffset_SequenceLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequenceBase.__PropertyOffset_SequenceLength) = value;
			}
		}

		// Token: 0x17001AB8 RID: 6840
		// (get) Token: 0x06007169 RID: 29033 RVA: 0x000A280C File Offset: 0x000A0A0C
		// (set) Token: 0x0600716A RID: 29034 RVA: 0x000A281C File Offset: 0x000A0A1C
		public unsafe float RateScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequenceBase.__PropertyOffset_RateScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequenceBase.__PropertyOffset_RateScale) = value;
			}
		}

		// Token: 0x17001AB9 RID: 6841
		// (get) Token: 0x0600716B RID: 29035 RVA: 0x000A282D File Offset: 0x000A0A2D
		// (set) Token: 0x0600716C RID: 29036 RVA: 0x000A2841 File Offset: 0x000A0A41
		public unsafe FName AnimOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequenceBase.__PropertyOffset_AnimOrigin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequenceBase.__PropertyOffset_AnimOrigin) = value;
			}
		}

		// Token: 0x17001ABA RID: 6842
		// (get) Token: 0x0600716D RID: 29037 RVA: 0x000A2858 File Offset: 0x000A0A58
		// (set) Token: 0x0600716E RID: 29038 RVA: 0x000A2891 File Offset: 0x000A0A91
		public FRawCurveTracks RawCurveData
		{
			get
			{
				base.FastCheckIsValid();
				FRawCurveTracks result;
				if ((result = this._RawCurveData) == null)
				{
					result = (this._RawCurveData = new FRawCurveTracks(base.NativePtr + (IntPtr)UAnimSequenceBase.__PropertyOffset_RawCurveData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawCurveTracks.StaticStruct(), base.NativePtr + (IntPtr)UAnimSequenceBase.__PropertyOffset_RawCurveData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001ABB RID: 6843
		// (get) Token: 0x0600716F RID: 29039 RVA: 0x000A28B4 File Offset: 0x000A0AB4
		// (set) Token: 0x06007170 RID: 29040 RVA: 0x000A28ED File Offset: 0x000A0AED
		public TArray<FAnimTextureTrack> AnimTextureTracks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimTextureTrack> result;
				if ((result = this._AnimTextureTracks) == null)
				{
					result = (this._AnimTextureTracks = new TArray<FAnimTextureTrack>(base.NativePtr + (IntPtr)UAnimSequenceBase.__PropertyOffset_AnimTextureTracks, this));
				}
				return result;
			}
			set
			{
				this.AnimTextureTracks.CopyAssign(value);
			}
		}

		// Token: 0x06007171 RID: 29041 RVA: 0x000A28FB File Offset: 0x000A0AFB
		public float GetPlayLength()
		{
			return UAnimSequenceBase.__GetPlayLength_Internal(base.NativePtr);
		}

		// Token: 0x06007172 RID: 29042
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPlayLength_Internal(IntPtr @this);

		// Token: 0x06007173 RID: 29043 RVA: 0x000A2908 File Offset: 0x000A0B08
		static UAnimSequenceBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimSequenceBase");
		}

		// Token: 0x06007174 RID: 29044 RVA: 0x000A2918 File Offset: 0x000A0B18
		protected UAnimSequenceBase() : this(BuiltinUtils.AllocNativeUObject(UAnimSequenceBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007175 RID: 29045 RVA: 0x000A2940 File Offset: 0x000A0B40
		protected UAnimSequenceBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003679 RID: 13945
		public new const string __ObjectPath = "/Script/Engine.AnimSequenceBase";

		// Token: 0x0400367A RID: 13946
		private static IntPtr _ClassPtr;

		// Token: 0x0400367B RID: 13947
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400367C RID: 13948
		internal static int __PropertyOffset_Notifies;

		// Token: 0x0400367D RID: 13949
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimNotifyEvent> _Notifies;

		// Token: 0x0400367E RID: 13950
		internal static int __PropertyOffset_SequenceLength;

		// Token: 0x0400367F RID: 13951
		internal static int __PropertyOffset_RateScale;

		// Token: 0x04003680 RID: 13952
		internal static int __PropertyOffset_AnimOrigin;

		// Token: 0x04003681 RID: 13953
		internal static int __PropertyOffset_RawCurveData;

		// Token: 0x04003682 RID: 13954
		[Nullable(2)]
		private FRawCurveTracks _RawCurveData;

		// Token: 0x04003683 RID: 13955
		internal static int __PropertyOffset_AnimTextureTracks;

		// Token: 0x04003684 RID: 13956
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimTextureTrack> _AnimTextureTracks;
	}
}

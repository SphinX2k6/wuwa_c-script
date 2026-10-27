using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BEE RID: 3054
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ForceFeedbackEffect")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UForceFeedbackEffect : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060096A7 RID: 38567 RVA: 0x000D6ECD File Offset: 0x000D50CD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UForceFeedbackEffect._ClassPtr;
		}

		// Token: 0x060096A8 RID: 38568 RVA: 0x000D6EDC File Offset: 0x000D50DC
		public UForceFeedbackEffect() : this(BuiltinUtils.AllocNativeUObject(UForceFeedbackEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060096A9 RID: 38569 RVA: 0x000D6F04 File Offset: 0x000D5104
		public UForceFeedbackEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UForceFeedbackEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002423 RID: 9251
		// (get) Token: 0x060096AA RID: 38570 RVA: 0x000D6F38 File Offset: 0x000D5138
		// (set) Token: 0x060096AB RID: 38571 RVA: 0x000D6F71 File Offset: 0x000D5171
		public TArray<FForceFeedbackChannelDetails> ChannelDetails
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FForceFeedbackChannelDetails> result;
				if ((result = this._ChannelDetails) == null)
				{
					result = (this._ChannelDetails = new TArray<FForceFeedbackChannelDetails>(base.NativePtr + (IntPtr)UForceFeedbackEffect.__PropertyOffset_ChannelDetails, this));
				}
				return result;
			}
			set
			{
				this.ChannelDetails.CopyAssign(value);
			}
		}

		// Token: 0x17002424 RID: 9252
		// (get) Token: 0x060096AC RID: 38572 RVA: 0x000D6F80 File Offset: 0x000D5180
		// (set) Token: 0x060096AD RID: 38573 RVA: 0x000D6FB9 File Offset: 0x000D51B9
		public TArray<FForceFeedbackChannelDetails> PsChannelDetails
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FForceFeedbackChannelDetails> result;
				if ((result = this._PsChannelDetails) == null)
				{
					result = (this._PsChannelDetails = new TArray<FForceFeedbackChannelDetails>(base.NativePtr + (IntPtr)UForceFeedbackEffect.__PropertyOffset_PsChannelDetails, this));
				}
				return result;
			}
			set
			{
				this.PsChannelDetails.CopyAssign(value);
			}
		}

		// Token: 0x17002425 RID: 9253
		// (get) Token: 0x060096AE RID: 38574 RVA: 0x000D6FC7 File Offset: 0x000D51C7
		// (set) Token: 0x060096AF RID: 38575 RVA: 0x000D6FD7 File Offset: 0x000D51D7
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UForceFeedbackEffect.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UForceFeedbackEffect.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x060096B0 RID: 38576 RVA: 0x000D6FE8 File Offset: 0x000D51E8
		static UForceFeedbackEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ForceFeedbackEffect");
		}

		// Token: 0x060096B1 RID: 38577 RVA: 0x000D6FF6 File Offset: 0x000D51F6
		protected UForceFeedbackEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005485 RID: 21637
		public new const string __ObjectPath = "/Script/Engine.ForceFeedbackEffect";

		// Token: 0x04005486 RID: 21638
		private static IntPtr _ClassPtr;

		// Token: 0x04005487 RID: 21639
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005488 RID: 21640
		internal static int __PropertyOffset_ChannelDetails;

		// Token: 0x04005489 RID: 21641
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FForceFeedbackChannelDetails> _ChannelDetails;

		// Token: 0x0400548A RID: 21642
		internal static int __PropertyOffset_PsChannelDetails;

		// Token: 0x0400548B RID: 21643
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FForceFeedbackChannelDetails> _PsChannelDetails;

		// Token: 0x0400548C RID: 21644
		internal static int __PropertyOffset_Duration;
	}
}

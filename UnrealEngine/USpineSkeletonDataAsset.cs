using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028B2 RID: 10418
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SpinePlugin.SpineSkeletonDataAsset")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class USpineSkeletonDataAsset : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026A51 RID: 158289 RVA: 0x003AF719 File Offset: 0x003AD919
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USpineSkeletonDataAsset._ClassPtr;
		}

		// Token: 0x06026A52 RID: 158290 RVA: 0x003AF728 File Offset: 0x003AD928
		public USpineSkeletonDataAsset() : this(BuiltinUtils.AllocNativeUObject(USpineSkeletonDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026A53 RID: 158291 RVA: 0x003AF750 File Offset: 0x003AD950
		public USpineSkeletonDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USpineSkeletonDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170094EE RID: 38126
		// (get) Token: 0x06026A54 RID: 158292 RVA: 0x003AF783 File Offset: 0x003AD983
		// (set) Token: 0x06026A55 RID: 158293 RVA: 0x003AF793 File Offset: 0x003AD993
		public unsafe float DefaultMix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpineSkeletonDataAsset.__PropertyOffset_DefaultMix);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpineSkeletonDataAsset.__PropertyOffset_DefaultMix) = value;
			}
		}

		// Token: 0x170094EF RID: 38127
		// (get) Token: 0x06026A56 RID: 158294 RVA: 0x003AF7A4 File Offset: 0x003AD9A4
		// (set) Token: 0x06026A57 RID: 158295 RVA: 0x003AF7DD File Offset: 0x003AD9DD
		public TArray<FSpineAnimationStateMixData> MixData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSpineAnimationStateMixData> result;
				if ((result = this._MixData) == null)
				{
					result = (this._MixData = new TArray<FSpineAnimationStateMixData>(base.NativePtr + (IntPtr)USpineSkeletonDataAsset.__PropertyOffset_MixData, this));
				}
				return result;
			}
			set
			{
				this.MixData.CopyAssign(value);
			}
		}

		// Token: 0x170094F0 RID: 38128
		// (get) Token: 0x06026A58 RID: 158296 RVA: 0x003AF7EC File Offset: 0x003AD9EC
		// (set) Token: 0x06026A59 RID: 158297 RVA: 0x003AF825 File Offset: 0x003ADA25
		public TArray<string> Bones
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Bones) == null)
				{
					result = (this._Bones = new TArray<string>(base.NativePtr + (IntPtr)USpineSkeletonDataAsset.__PropertyOffset_Bones, this));
				}
				return result;
			}
			set
			{
				this.Bones.CopyAssign(value);
			}
		}

		// Token: 0x170094F1 RID: 38129
		// (get) Token: 0x06026A5A RID: 158298 RVA: 0x003AF834 File Offset: 0x003ADA34
		// (set) Token: 0x06026A5B RID: 158299 RVA: 0x003AF86D File Offset: 0x003ADA6D
		public TArray<string> Slots
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Slots) == null)
				{
					result = (this._Slots = new TArray<string>(base.NativePtr + (IntPtr)USpineSkeletonDataAsset.__PropertyOffset_Slots, this));
				}
				return result;
			}
			set
			{
				this.Slots.CopyAssign(value);
			}
		}

		// Token: 0x170094F2 RID: 38130
		// (get) Token: 0x06026A5C RID: 158300 RVA: 0x003AF87C File Offset: 0x003ADA7C
		// (set) Token: 0x06026A5D RID: 158301 RVA: 0x003AF8B5 File Offset: 0x003ADAB5
		public TArray<string> Skins
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Skins) == null)
				{
					result = (this._Skins = new TArray<string>(base.NativePtr + (IntPtr)USpineSkeletonDataAsset.__PropertyOffset_Skins, this));
				}
				return result;
			}
			set
			{
				this.Skins.CopyAssign(value);
			}
		}

		// Token: 0x170094F3 RID: 38131
		// (get) Token: 0x06026A5E RID: 158302 RVA: 0x003AF8C4 File Offset: 0x003ADAC4
		// (set) Token: 0x06026A5F RID: 158303 RVA: 0x003AF8FD File Offset: 0x003ADAFD
		public TArray<string> Animations
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Animations) == null)
				{
					result = (this._Animations = new TArray<string>(base.NativePtr + (IntPtr)USpineSkeletonDataAsset.__PropertyOffset_Animations, this));
				}
				return result;
			}
			set
			{
				this.Animations.CopyAssign(value);
			}
		}

		// Token: 0x170094F4 RID: 38132
		// (get) Token: 0x06026A60 RID: 158304 RVA: 0x003AF90C File Offset: 0x003ADB0C
		// (set) Token: 0x06026A61 RID: 158305 RVA: 0x003AF945 File Offset: 0x003ADB45
		public TArray<string> Events
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Events) == null)
				{
					result = (this._Events = new TArray<string>(base.NativePtr + (IntPtr)USpineSkeletonDataAsset.__PropertyOffset_Events, this));
				}
				return result;
			}
			set
			{
				this.Events.CopyAssign(value);
			}
		}

		// Token: 0x170094F5 RID: 38133
		// (get) Token: 0x06026A62 RID: 158306 RVA: 0x003AF954 File Offset: 0x003ADB54
		// (set) Token: 0x06026A63 RID: 158307 RVA: 0x003AF98D File Offset: 0x003ADB8D
		public TArray<byte> rawData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._rawData) == null)
				{
					result = (this._rawData = new TArray<byte>(base.NativePtr + (IntPtr)USpineSkeletonDataAsset.__PropertyOffset_rawData, this));
				}
				return result;
			}
			set
			{
				this.rawData.CopyAssign(value);
			}
		}

		// Token: 0x170094F6 RID: 38134
		// (get) Token: 0x06026A64 RID: 158308 RVA: 0x003AF99B File Offset: 0x003ADB9B
		// (set) Token: 0x06026A65 RID: 158309 RVA: 0x003AF9AF File Offset: 0x003ADBAF
		public unsafe FName skeletonDataFileName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpineSkeletonDataAsset.__PropertyOffset_skeletonDataFileName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpineSkeletonDataAsset.__PropertyOffset_skeletonDataFileName) = value;
			}
		}

		// Token: 0x06026A66 RID: 158310 RVA: 0x003AF9C4 File Offset: 0x003ADBC4
		static USpineSkeletonDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SpinePlugin.SpineSkeletonDataAsset");
		}

		// Token: 0x06026A67 RID: 158311 RVA: 0x003AF9D2 File Offset: 0x003ADBD2
		protected USpineSkeletonDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015378 RID: 86904
		public new const string __ObjectPath = "/Script/SpinePlugin.SpineSkeletonDataAsset";

		// Token: 0x04015379 RID: 86905
		private static IntPtr _ClassPtr;

		// Token: 0x0401537A RID: 86906
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401537B RID: 86907
		internal static int __PropertyOffset_DefaultMix;

		// Token: 0x0401537C RID: 86908
		internal static int __PropertyOffset_MixData;

		// Token: 0x0401537D RID: 86909
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSpineAnimationStateMixData> _MixData;

		// Token: 0x0401537E RID: 86910
		internal static int __PropertyOffset_Bones;

		// Token: 0x0401537F RID: 86911
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Bones;

		// Token: 0x04015380 RID: 86912
		internal static int __PropertyOffset_Slots;

		// Token: 0x04015381 RID: 86913
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Slots;

		// Token: 0x04015382 RID: 86914
		internal static int __PropertyOffset_Skins;

		// Token: 0x04015383 RID: 86915
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Skins;

		// Token: 0x04015384 RID: 86916
		internal static int __PropertyOffset_Animations;

		// Token: 0x04015385 RID: 86917
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Animations;

		// Token: 0x04015386 RID: 86918
		internal static int __PropertyOffset_Events;

		// Token: 0x04015387 RID: 86919
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Events;

		// Token: 0x04015388 RID: 86920
		internal static int __PropertyOffset_rawData;

		// Token: 0x04015389 RID: 86921
		[Nullable(2)]
		private TArray<byte> _rawData;

		// Token: 0x0401538A RID: 86922
		internal static int __PropertyOffset_skeletonDataFileName;
	}
}

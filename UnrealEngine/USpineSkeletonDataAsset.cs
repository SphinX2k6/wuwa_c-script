using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000841 RID: 2113
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SpinePlugin.SpineSkeletonDataAsset")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class USpineSkeletonDataAsset : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B83F RID: 47167 RVA: 0x00127475 File Offset: 0x00125675
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USpineSkeletonDataAsset._ClassPtr;
		}

		// Token: 0x0600B840 RID: 47168 RVA: 0x00127484 File Offset: 0x00125684
		public USpineSkeletonDataAsset() : this(BuiltinUtils.AllocNativeUObject(USpineSkeletonDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B841 RID: 47169 RVA: 0x001274AC File Offset: 0x001256AC
		public USpineSkeletonDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USpineSkeletonDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002259 RID: 8793
		// (get) Token: 0x0600B842 RID: 47170 RVA: 0x001274DF File Offset: 0x001256DF
		// (set) Token: 0x0600B843 RID: 47171 RVA: 0x001274EF File Offset: 0x001256EF
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

		// Token: 0x1700225A RID: 8794
		// (get) Token: 0x0600B844 RID: 47172 RVA: 0x00127500 File Offset: 0x00125700
		// (set) Token: 0x0600B845 RID: 47173 RVA: 0x00127539 File Offset: 0x00125739
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

		// Token: 0x1700225B RID: 8795
		// (get) Token: 0x0600B846 RID: 47174 RVA: 0x00127548 File Offset: 0x00125748
		// (set) Token: 0x0600B847 RID: 47175 RVA: 0x00127581 File Offset: 0x00125781
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

		// Token: 0x1700225C RID: 8796
		// (get) Token: 0x0600B848 RID: 47176 RVA: 0x00127590 File Offset: 0x00125790
		// (set) Token: 0x0600B849 RID: 47177 RVA: 0x001275C9 File Offset: 0x001257C9
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

		// Token: 0x1700225D RID: 8797
		// (get) Token: 0x0600B84A RID: 47178 RVA: 0x001275D8 File Offset: 0x001257D8
		// (set) Token: 0x0600B84B RID: 47179 RVA: 0x00127611 File Offset: 0x00125811
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

		// Token: 0x1700225E RID: 8798
		// (get) Token: 0x0600B84C RID: 47180 RVA: 0x00127620 File Offset: 0x00125820
		// (set) Token: 0x0600B84D RID: 47181 RVA: 0x00127659 File Offset: 0x00125859
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

		// Token: 0x1700225F RID: 8799
		// (get) Token: 0x0600B84E RID: 47182 RVA: 0x00127668 File Offset: 0x00125868
		// (set) Token: 0x0600B84F RID: 47183 RVA: 0x001276A1 File Offset: 0x001258A1
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

		// Token: 0x17002260 RID: 8800
		// (get) Token: 0x0600B850 RID: 47184 RVA: 0x001276AF File Offset: 0x001258AF
		// (set) Token: 0x0600B851 RID: 47185 RVA: 0x001276C3 File Offset: 0x001258C3
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

		// Token: 0x0600B852 RID: 47186 RVA: 0x001276D8 File Offset: 0x001258D8
		static USpineSkeletonDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SpinePlugin.SpineSkeletonDataAsset");
		}

		// Token: 0x0600B853 RID: 47187 RVA: 0x001276E6 File Offset: 0x001258E6
		protected USpineSkeletonDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040053A2 RID: 21410
		public new const string __ObjectPath = "/Script/SpinePlugin.SpineSkeletonDataAsset";

		// Token: 0x040053A3 RID: 21411
		private static IntPtr _ClassPtr;

		// Token: 0x040053A4 RID: 21412
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040053A5 RID: 21413
		internal static int __PropertyOffset_DefaultMix;

		// Token: 0x040053A6 RID: 21414
		internal static int __PropertyOffset_Bones;

		// Token: 0x040053A7 RID: 21415
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Bones;

		// Token: 0x040053A8 RID: 21416
		internal static int __PropertyOffset_Slots;

		// Token: 0x040053A9 RID: 21417
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Slots;

		// Token: 0x040053AA RID: 21418
		internal static int __PropertyOffset_Skins;

		// Token: 0x040053AB RID: 21419
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Skins;

		// Token: 0x040053AC RID: 21420
		internal static int __PropertyOffset_Animations;

		// Token: 0x040053AD RID: 21421
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Animations;

		// Token: 0x040053AE RID: 21422
		internal static int __PropertyOffset_Events;

		// Token: 0x040053AF RID: 21423
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Events;

		// Token: 0x040053B0 RID: 21424
		internal static int __PropertyOffset_rawData;

		// Token: 0x040053B1 RID: 21425
		[Nullable(2)]
		private TArray<byte> _rawData;

		// Token: 0x040053B2 RID: 21426
		internal static int __PropertyOffset_skeletonDataFileName;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EA9 RID: 7849
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroActorLevelVolume")]
	[UnrealStructLayout(1544, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1544)]
	public class AKuroActorLevelVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DCC8 RID: 122056 RVA: 0x002C0AC1 File Offset: 0x002BECC1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroActorLevelVolume._ClassPtr;
		}

		// Token: 0x0601DCC9 RID: 122057 RVA: 0x002C0AD0 File Offset: 0x002BECD0
		public AKuroActorLevelVolume() : this(BuiltinUtils.AllocNativeUObject(AKuroActorLevelVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DCCA RID: 122058 RVA: 0x002C0AF8 File Offset: 0x002BECF8
		public AKuroActorLevelVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroActorLevelVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700778E RID: 30606
		// (get) Token: 0x0601DCCB RID: 122059 RVA: 0x002C0B2B File Offset: 0x002BED2B
		// (set) Token: 0x0601DCCC RID: 122060 RVA: 0x002C0B3F File Offset: 0x002BED3F
		public unsafe FName VolumeId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroActorLevelVolume.__PropertyOffset_VolumeId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroActorLevelVolume.__PropertyOffset_VolumeId) = value;
			}
		}

		// Token: 0x1700778F RID: 30607
		// (get) Token: 0x0601DCCD RID: 122061 RVA: 0x002C0B54 File Offset: 0x002BED54
		// (set) Token: 0x0601DCCE RID: 122062 RVA: 0x002C0B68 File Offset: 0x002BED68
		public unsafe string TAPDUrl
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)AKuroActorLevelVolume.__PropertyOffset_TAPDUrl)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)AKuroActorLevelVolume.__PropertyOffset_TAPDUrl)), value);
			}
		}

		// Token: 0x17007790 RID: 30608
		// (get) Token: 0x0601DCCF RID: 122063 RVA: 0x002C0B80 File Offset: 0x002BED80
		// (set) Token: 0x0601DCD0 RID: 122064 RVA: 0x002C0BB9 File Offset: 0x002BEDB9
		public TSet<string> ExcludeActorType
		{
			get
			{
				base.FastCheckIsValid();
				TSet<string> result;
				if ((result = this._ExcludeActorType) == null)
				{
					result = (this._ExcludeActorType = new TSet<string>(base.NativePtr + (IntPtr)AKuroActorLevelVolume.__PropertyOffset_ExcludeActorType, this));
				}
				return result;
			}
			set
			{
				this.ExcludeActorType.CopyAssign(value);
			}
		}

		// Token: 0x17007791 RID: 30609
		// (get) Token: 0x0601DCD1 RID: 122065 RVA: 0x002C0BC8 File Offset: 0x002BEDC8
		// (set) Token: 0x0601DCD2 RID: 122066 RVA: 0x002C0C01 File Offset: 0x002BEE01
		public TSet<string> ExcludeActorName
		{
			get
			{
				base.FastCheckIsValid();
				TSet<string> result;
				if ((result = this._ExcludeActorName) == null)
				{
					result = (this._ExcludeActorName = new TSet<string>(base.NativePtr + (IntPtr)AKuroActorLevelVolume.__PropertyOffset_ExcludeActorName, this));
				}
				return result;
			}
			set
			{
				this.ExcludeActorName.CopyAssign(value);
			}
		}

		// Token: 0x17007792 RID: 30610
		// (get) Token: 0x0601DCD3 RID: 122067 RVA: 0x002C0C0F File Offset: 0x002BEE0F
		// (set) Token: 0x0601DCD4 RID: 122068 RVA: 0x002C0C1F File Offset: 0x002BEE1F
		public unsafe EActorPartitionVolumeType Type
		{
			get
			{
				return (EActorPartitionVolumeType)(*(base.NativePtr + (IntPtr)AKuroActorLevelVolume.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroActorLevelVolume.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x0601DCD5 RID: 122069 RVA: 0x002C0C30 File Offset: 0x002BEE30
		static AKuroActorLevelVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroActorLevelVolume");
		}

		// Token: 0x0601DCD6 RID: 122070 RVA: 0x002C0C3E File Offset: 0x002BEE3E
		protected AKuroActorLevelVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010250 RID: 66128
		public new const string __ObjectPath = "/Script/KuroUtility.KuroActorLevelVolume";

		// Token: 0x04010251 RID: 66129
		private static IntPtr _ClassPtr;

		// Token: 0x04010252 RID: 66130
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010253 RID: 66131
		internal static int __PropertyOffset_VolumeId;

		// Token: 0x04010254 RID: 66132
		internal static int __PropertyOffset_TAPDUrl;

		// Token: 0x04010255 RID: 66133
		internal static int __PropertyOffset_ExcludeActorType;

		// Token: 0x04010256 RID: 66134
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<string> _ExcludeActorType;

		// Token: 0x04010257 RID: 66135
		internal static int __PropertyOffset_ExcludeActorName;

		// Token: 0x04010258 RID: 66136
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<string> _ExcludeActorName;

		// Token: 0x04010259 RID: 66137
		internal static int __PropertyOffset_Type;
	}
}

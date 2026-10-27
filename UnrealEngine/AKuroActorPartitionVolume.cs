using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EAB RID: 7851
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroActorPartitionVolume")]
	[UnrealStructLayout(1632, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1632)]
	public class AKuroActorPartitionVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DCEF RID: 122095 RVA: 0x002C13BD File Offset: 0x002BF5BD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroActorPartitionVolume._ClassPtr;
		}

		// Token: 0x0601DCF0 RID: 122096 RVA: 0x002C13CC File Offset: 0x002BF5CC
		public AKuroActorPartitionVolume() : this(BuiltinUtils.AllocNativeUObject(AKuroActorPartitionVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DCF1 RID: 122097 RVA: 0x002C13F4 File Offset: 0x002BF5F4
		public AKuroActorPartitionVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroActorPartitionVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007793 RID: 30611
		// (get) Token: 0x0601DCF2 RID: 122098 RVA: 0x002C1427 File Offset: 0x002BF627
		// (set) Token: 0x0601DCF3 RID: 122099 RVA: 0x002C143B File Offset: 0x002BF63B
		public unsafe FName VolumeId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroActorPartitionVolume.__PropertyOffset_VolumeId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroActorPartitionVolume.__PropertyOffset_VolumeId) = value;
			}
		}

		// Token: 0x17007794 RID: 30612
		// (get) Token: 0x0601DCF4 RID: 122100 RVA: 0x002C1450 File Offset: 0x002BF650
		// (set) Token: 0x0601DCF5 RID: 122101 RVA: 0x002C1464 File Offset: 0x002BF664
		public unsafe string BotURL
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)AKuroActorPartitionVolume.__PropertyOffset_BotURL)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)AKuroActorPartitionVolume.__PropertyOffset_BotURL)), value);
			}
		}

		// Token: 0x17007795 RID: 30613
		// (get) Token: 0x0601DCF6 RID: 122102 RVA: 0x002C1479 File Offset: 0x002BF679
		// (set) Token: 0x0601DCF7 RID: 122103 RVA: 0x002C1489 File Offset: 0x002BF689
		public unsafe EActorPartitionVolumeType Type
		{
			get
			{
				return (EActorPartitionVolumeType)(*(base.NativePtr + (IntPtr)AKuroActorPartitionVolume.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroActorPartitionVolume.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x17007796 RID: 30614
		// (get) Token: 0x0601DCF8 RID: 122104 RVA: 0x002C149C File Offset: 0x002BF69C
		// (set) Token: 0x0601DCF9 RID: 122105 RVA: 0x002C14D5 File Offset: 0x002BF6D5
		public TSet<string> ExcludeActorType
		{
			get
			{
				base.FastCheckIsValid();
				TSet<string> result;
				if ((result = this._ExcludeActorType) == null)
				{
					result = (this._ExcludeActorType = new TSet<string>(base.NativePtr + (IntPtr)AKuroActorPartitionVolume.__PropertyOffset_ExcludeActorType, this));
				}
				return result;
			}
			set
			{
				this.ExcludeActorType.CopyAssign(value);
			}
		}

		// Token: 0x17007797 RID: 30615
		// (get) Token: 0x0601DCFA RID: 122106 RVA: 0x002C14E4 File Offset: 0x002BF6E4
		// (set) Token: 0x0601DCFB RID: 122107 RVA: 0x002C151D File Offset: 0x002BF71D
		public TSet<string> ExcludeActorName
		{
			get
			{
				base.FastCheckIsValid();
				TSet<string> result;
				if ((result = this._ExcludeActorName) == null)
				{
					result = (this._ExcludeActorName = new TSet<string>(base.NativePtr + (IntPtr)AKuroActorPartitionVolume.__PropertyOffset_ExcludeActorName, this));
				}
				return result;
			}
			set
			{
				this.ExcludeActorName.CopyAssign(value);
			}
		}

		// Token: 0x0601DCFC RID: 122108 RVA: 0x002C152B File Offset: 0x002BF72B
		static AKuroActorPartitionVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroActorPartitionVolume");
		}

		// Token: 0x0601DCFD RID: 122109 RVA: 0x002C1539 File Offset: 0x002BF739
		protected AKuroActorPartitionVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010270 RID: 66160
		public new const string __ObjectPath = "/Script/KuroUtility.KuroActorPartitionVolume";

		// Token: 0x04010271 RID: 66161
		private static IntPtr _ClassPtr;

		// Token: 0x04010272 RID: 66162
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010273 RID: 66163
		internal static int __PropertyOffset_VolumeId;

		// Token: 0x04010274 RID: 66164
		internal static int __PropertyOffset_BotURL;

		// Token: 0x04010275 RID: 66165
		internal static int __PropertyOffset_Type;

		// Token: 0x04010276 RID: 66166
		internal static int __PropertyOffset_ExcludeActorType;

		// Token: 0x04010277 RID: 66167
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<string> _ExcludeActorType;

		// Token: 0x04010278 RID: 66168
		internal static int __PropertyOffset_ExcludeActorName;

		// Token: 0x04010279 RID: 66169
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<string> _ExcludeActorName;
	}
}

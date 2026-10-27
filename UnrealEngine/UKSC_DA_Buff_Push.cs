using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D7A RID: 7546
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Buff_Push")]
	[UnrealStructLayout(496, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 496)]
	public class UKSC_DA_Buff_Push : UKSC_DA_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CE6C RID: 118380 RVA: 0x002AB872 File Offset: 0x002A9A72
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Buff_Push._ClassPtr;
		}

		// Token: 0x0601CE6D RID: 118381 RVA: 0x002AB880 File Offset: 0x002A9A80
		public UKSC_DA_Buff_Push() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Push.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CE6E RID: 118382 RVA: 0x002AB8A8 File Offset: 0x002A9AA8
		[NullableContext(1)]
		public UKSC_DA_Buff_Push(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Buff_Push.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007489 RID: 29833
		// (get) Token: 0x0601CE6F RID: 118383 RVA: 0x002AB8DB File Offset: 0x002A9ADB
		// (set) Token: 0x0601CE70 RID: 118384 RVA: 0x002AB8EF File Offset: 0x002A9AEF
		public unsafe FVector PushDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Push.__PropertyOffset_PushDir);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Push.__PropertyOffset_PushDir) = value;
			}
		}

		// Token: 0x1700748A RID: 29834
		// (get) Token: 0x0601CE71 RID: 118385 RVA: 0x002AB904 File Offset: 0x002A9B04
		// (set) Token: 0x0601CE72 RID: 118386 RVA: 0x002AB914 File Offset: 0x002A9B14
		public unsafe float PushSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Push.__PropertyOffset_PushSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Push.__PropertyOffset_PushSpeed) = value;
			}
		}

		// Token: 0x1700748B RID: 29835
		// (get) Token: 0x0601CE73 RID: 118387 RVA: 0x002AB925 File Offset: 0x002A9B25
		// (set) Token: 0x0601CE74 RID: 118388 RVA: 0x002AB935 File Offset: 0x002A9B35
		public unsafe float MaxSimTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Push.__PropertyOffset_MaxSimTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Push.__PropertyOffset_MaxSimTime) = value;
			}
		}

		// Token: 0x1700748C RID: 29836
		// (get) Token: 0x0601CE75 RID: 118389 RVA: 0x002AB946 File Offset: 0x002A9B46
		// (set) Token: 0x0601CE76 RID: 118390 RVA: 0x002AB956 File Offset: 0x002A9B56
		public unsafe float SimFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Push.__PropertyOffset_SimFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Push.__PropertyOffset_SimFrequency) = value;
			}
		}

		// Token: 0x1700748D RID: 29837
		// (get) Token: 0x0601CE77 RID: 118391 RVA: 0x002AB967 File Offset: 0x002A9B67
		// (set) Token: 0x0601CE78 RID: 118392 RVA: 0x002AB977 File Offset: 0x002A9B77
		public unsafe float QueryOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Push.__PropertyOffset_QueryOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Push.__PropertyOffset_QueryOffset) = value;
			}
		}

		// Token: 0x1700748E RID: 29838
		// (get) Token: 0x0601CE79 RID: 118393 RVA: 0x002AB988 File Offset: 0x002A9B88
		// (set) Token: 0x0601CE7A RID: 118394 RVA: 0x002AB998 File Offset: 0x002A9B98
		public unsafe bool TraceWithCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Push.__PropertyOffset_TraceWithCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Push.__PropertyOffset_TraceWithCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700748F RID: 29839
		// (get) Token: 0x0601CE7B RID: 118395 RVA: 0x002AB9AC File Offset: 0x002A9BAC
		// (set) Token: 0x0601CE7C RID: 118396 RVA: 0x002AB9E5 File Offset: 0x002A9BE5
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EObjectTypeQuery>> result;
				if ((result = this._ObjectTypes) == null)
				{
					result = (this._ObjectTypes = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)UKSC_DA_Buff_Push.__PropertyOffset_ObjectTypes, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.ObjectTypes.CopyAssign(value);
			}
		}

		// Token: 0x17007490 RID: 29840
		// (get) Token: 0x0601CE7D RID: 118397 RVA: 0x002AB9F3 File Offset: 0x002A9BF3
		// (set) Token: 0x0601CE7E RID: 118398 RVA: 0x002ABA07 File Offset: 0x002A9C07
		public unsafe TEnumAsByte<ECollisionChannel> TraceChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Push.__PropertyOffset_TraceChannel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Push.__PropertyOffset_TraceChannel) = value;
			}
		}

		// Token: 0x17007491 RID: 29841
		// (get) Token: 0x0601CE7F RID: 118399 RVA: 0x002ABA1C File Offset: 0x002A9C1C
		// (set) Token: 0x0601CE80 RID: 118400 RVA: 0x002ABA30 File Offset: 0x002A9C30
		public unsafe FVector NavSearch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Buff_Push.__PropertyOffset_NavSearch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Buff_Push.__PropertyOffset_NavSearch) = value;
			}
		}

		// Token: 0x0601CE81 RID: 118401 RVA: 0x002ABA45 File Offset: 0x002A9C45
		static UKSC_DA_Buff_Push()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Buff_Push");
		}

		// Token: 0x0601CE82 RID: 118402 RVA: 0x002ABA53 File Offset: 0x002A9C53
		protected UKSC_DA_Buff_Push(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FAEA RID: 64234
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Buff_Push";

		// Token: 0x0400FAEB RID: 64235
		private static IntPtr _ClassPtr;

		// Token: 0x0400FAEC RID: 64236
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FAED RID: 64237
		internal static int __PropertyOffset_PushDir;

		// Token: 0x0400FAEE RID: 64238
		internal static int __PropertyOffset_PushSpeed;

		// Token: 0x0400FAEF RID: 64239
		internal static int __PropertyOffset_MaxSimTime;

		// Token: 0x0400FAF0 RID: 64240
		internal static int __PropertyOffset_SimFrequency;

		// Token: 0x0400FAF1 RID: 64241
		internal static int __PropertyOffset_QueryOffset;

		// Token: 0x0400FAF2 RID: 64242
		internal static int __PropertyOffset_TraceWithCollision;

		// Token: 0x0400FAF3 RID: 64243
		internal static int __PropertyOffset_ObjectTypes;

		// Token: 0x0400FAF4 RID: 64244
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _ObjectTypes;

		// Token: 0x0400FAF5 RID: 64245
		internal static int __PropertyOffset_TraceChannel;

		// Token: 0x0400FAF6 RID: 64246
		internal static int __PropertyOffset_NavSearch;
	}
}

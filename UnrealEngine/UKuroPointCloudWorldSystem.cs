using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A35 RID: 6709
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroPointCloud.KuroPointCloudWorldSystem")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UKuroPointCloudWorldSystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018D60 RID: 101728 RVA: 0x0024B129 File Offset: 0x00249329
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPointCloudWorldSystem._ClassPtr;
		}

		// Token: 0x06018D61 RID: 101729 RVA: 0x0024B138 File Offset: 0x00249338
		public UKuroPointCloudWorldSystem() : this(BuiltinUtils.AllocNativeUObject(UKuroPointCloudWorldSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018D62 RID: 101730 RVA: 0x0024B160 File Offset: 0x00249360
		public UKuroPointCloudWorldSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPointCloudWorldSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006261 RID: 25185
		// (get) Token: 0x06018D63 RID: 101731 RVA: 0x0024B193 File Offset: 0x00249393
		// (set) Token: 0x06018D64 RID: 101732 RVA: 0x0024B1A7 File Offset: 0x002493A7
		[Nullable(2)]
		public unsafe UKuroPointCloudStreamer Streamer
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPointCloudStreamer>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroPointCloudWorldSystem.__PropertyOffset_Streamer);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroPointCloudWorldSystem.__PropertyOffset_Streamer, value);
			}
		}

		// Token: 0x17006262 RID: 25186
		// (get) Token: 0x06018D65 RID: 101733 RVA: 0x0024B1BC File Offset: 0x002493BC
		// (set) Token: 0x06018D66 RID: 101734 RVA: 0x0024B1F5 File Offset: 0x002493F5
		public TMap<FName, FKuroPointCloudWorldCollection> Collections
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroPointCloudWorldCollection> result;
				if ((result = this._Collections) == null)
				{
					result = (this._Collections = new TMap<FName, FKuroPointCloudWorldCollection>(base.NativePtr + (IntPtr)UKuroPointCloudWorldSystem.__PropertyOffset_Collections, this));
				}
				return result;
			}
			set
			{
				this.Collections.CopyAssign(value);
			}
		}

		// Token: 0x17006263 RID: 25187
		// (get) Token: 0x06018D67 RID: 101735 RVA: 0x0024B203 File Offset: 0x00249403
		// (set) Token: 0x06018D68 RID: 101736 RVA: 0x0024B213 File Offset: 0x00249413
		public unsafe int NextAvailableKey
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroPointCloudWorldSystem.__PropertyOffset_NextAvailableKey);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroPointCloudWorldSystem.__PropertyOffset_NextAvailableKey) = value;
			}
		}

		// Token: 0x06018D69 RID: 101737 RVA: 0x0024B224 File Offset: 0x00249424
		[NullableContext(2)]
		public void SetStreamingConfig(UKuroPointCloudStreamingConfig Config, float StreamingDistance = 30000f)
		{
			UKuroPointCloudWorldSystem.__SetStreamingConfig_Internal(base.NativePtr, (Config != null) ? Config.NativePtr : IntPtr.Zero, StreamingDistance);
		}

		// Token: 0x06018D6A RID: 101738 RVA: 0x0024B242 File Offset: 0x00249442
		public int GetNextAvailableKey()
		{
			return UKuroPointCloudWorldSystem.__GetNextAvailableKey_Internal(base.NativePtr);
		}

		// Token: 0x06018D6B RID: 101739
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStreamingConfig_Internal(IntPtr @this, IntPtr Config, float StreamingDistance);

		// Token: 0x06018D6C RID: 101740
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNextAvailableKey_Internal(IntPtr @this);

		// Token: 0x06018D6D RID: 101741 RVA: 0x0024B24F File Offset: 0x0024944F
		static UKuroPointCloudWorldSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroPointCloud.KuroPointCloudWorldSystem");
		}

		// Token: 0x06018D6E RID: 101742 RVA: 0x0024B25D File Offset: 0x0024945D
		protected UKuroPointCloudWorldSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D6B7 RID: 54967
		public new const string __ObjectPath = "/Script/KuroPointCloud.KuroPointCloudWorldSystem";

		// Token: 0x0400D6B8 RID: 54968
		private static IntPtr _ClassPtr;

		// Token: 0x0400D6B9 RID: 54969
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D6BA RID: 54970
		internal static int __PropertyOffset_Streamer;

		// Token: 0x0400D6BB RID: 54971
		internal static int __PropertyOffset_Collections;

		// Token: 0x0400D6BC RID: 54972
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroPointCloudWorldCollection> _Collections;

		// Token: 0x0400D6BD RID: 54973
		internal static int __PropertyOffset_NextAvailableKey;
	}
}

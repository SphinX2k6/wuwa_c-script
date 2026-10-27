using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003C6 RID: 966
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARSharedWorldGameState")]
	[UnrealStructLayout(1224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1224)]
	public class AARSharedWorldGameState : AGameState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600361D RID: 13853 RVA: 0x00052332 File Offset: 0x00050532
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AARSharedWorldGameState._ClassPtr;
		}

		// Token: 0x0600361E RID: 13854 RVA: 0x00052340 File Offset: 0x00050540
		public AARSharedWorldGameState() : this(BuiltinUtils.AllocNativeUObject(AARSharedWorldGameState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600361F RID: 13855 RVA: 0x00052368 File Offset: 0x00050568
		public AARSharedWorldGameState(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AARSharedWorldGameState.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x06003620 RID: 13856 RVA: 0x0005239C File Offset: 0x0005059C
		// (set) Token: 0x06003621 RID: 13857 RVA: 0x000523D5 File Offset: 0x000505D5
		public TArray<byte> PreviewImageData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._PreviewImageData) == null)
				{
					result = (this._PreviewImageData = new TArray<byte>(base.NativePtr + (IntPtr)AARSharedWorldGameState.__PropertyOffset_PreviewImageData, this));
				}
				return result;
			}
			set
			{
				this.PreviewImageData.CopyAssign(value);
			}
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06003622 RID: 13858 RVA: 0x000523E4 File Offset: 0x000505E4
		// (set) Token: 0x06003623 RID: 13859 RVA: 0x0005241D File Offset: 0x0005061D
		public TArray<byte> ARWorldData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._ARWorldData) == null)
				{
					result = (this._ARWorldData = new TArray<byte>(base.NativePtr + (IntPtr)AARSharedWorldGameState.__PropertyOffset_ARWorldData, this));
				}
				return result;
			}
			set
			{
				this.ARWorldData.CopyAssign(value);
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x06003624 RID: 13860 RVA: 0x0005242B File Offset: 0x0005062B
		// (set) Token: 0x06003625 RID: 13861 RVA: 0x0005243B File Offset: 0x0005063B
		public unsafe int PreviewImageBytesTotal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AARSharedWorldGameState.__PropertyOffset_PreviewImageBytesTotal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AARSharedWorldGameState.__PropertyOffset_PreviewImageBytesTotal) = value;
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x06003626 RID: 13862 RVA: 0x0005244C File Offset: 0x0005064C
		// (set) Token: 0x06003627 RID: 13863 RVA: 0x0005245C File Offset: 0x0005065C
		public unsafe int ARWorldBytesTotal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AARSharedWorldGameState.__PropertyOffset_ARWorldBytesTotal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AARSharedWorldGameState.__PropertyOffset_ARWorldBytesTotal) = value;
			}
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x06003628 RID: 13864 RVA: 0x0005246D File Offset: 0x0005066D
		// (set) Token: 0x06003629 RID: 13865 RVA: 0x0005247D File Offset: 0x0005067D
		public unsafe int PreviewImageBytesDelivered
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AARSharedWorldGameState.__PropertyOffset_PreviewImageBytesDelivered);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AARSharedWorldGameState.__PropertyOffset_PreviewImageBytesDelivered) = value;
			}
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x0600362A RID: 13866 RVA: 0x0005248E File Offset: 0x0005068E
		// (set) Token: 0x0600362B RID: 13867 RVA: 0x0005249E File Offset: 0x0005069E
		public unsafe int ARWorldBytesDelivered
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AARSharedWorldGameState.__PropertyOffset_ARWorldBytesDelivered);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AARSharedWorldGameState.__PropertyOffset_ARWorldBytesDelivered) = value;
			}
		}

		// Token: 0x0600362C RID: 13868 RVA: 0x000524AF File Offset: 0x000506AF
		public virtual void K2_OnARWorldMapIsReady()
		{
			AARSharedWorldGameState.__K2_OnARWorldMapIsReady_Internal(base.NativePtr);
		}

		// Token: 0x0600362D RID: 13869
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_OnARWorldMapIsReady_Internal(IntPtr @this);

		// Token: 0x0600362E RID: 13870 RVA: 0x000524BC File Offset: 0x000506BC
		static AARSharedWorldGameState()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARSharedWorldGameState");
		}

		// Token: 0x0600362F RID: 13871 RVA: 0x000524CA File Offset: 0x000506CA
		protected AARSharedWorldGameState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001764 RID: 5988
		public new const string __ObjectPath = "/Script/AugmentedReality.ARSharedWorldGameState";

		// Token: 0x04001765 RID: 5989
		private static IntPtr _ClassPtr;

		// Token: 0x04001766 RID: 5990
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001767 RID: 5991
		internal static int __PropertyOffset_PreviewImageData;

		// Token: 0x04001768 RID: 5992
		[Nullable(2)]
		private TArray<byte> _PreviewImageData;

		// Token: 0x04001769 RID: 5993
		internal static int __PropertyOffset_ARWorldData;

		// Token: 0x0400176A RID: 5994
		[Nullable(2)]
		private TArray<byte> _ARWorldData;

		// Token: 0x0400176B RID: 5995
		internal static int __PropertyOffset_PreviewImageBytesTotal;

		// Token: 0x0400176C RID: 5996
		internal static int __PropertyOffset_ARWorldBytesTotal;

		// Token: 0x0400176D RID: 5997
		internal static int __PropertyOffset_PreviewImageBytesDelivered;

		// Token: 0x0400176E RID: 5998
		internal static int __PropertyOffset_ARWorldBytesDelivered;
	}
}

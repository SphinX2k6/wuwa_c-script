using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200248B RID: 9355
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/NavigationSystem.NavigationDataChunkTileVariantsActor")]
	[UnrealStructLayout(1616, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1616)]
	public class ANavigationDataChunkTileVariantsActor : ANavigationDataChunkActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022FCA RID: 143306 RVA: 0x0033B9E9 File Offset: 0x00339BE9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ANavigationDataChunkTileVariantsActor._ClassPtr;
		}

		// Token: 0x06022FCB RID: 143307 RVA: 0x0033B9F8 File Offset: 0x00339BF8
		public ANavigationDataChunkTileVariantsActor() : this(BuiltinUtils.AllocNativeUObject(ANavigationDataChunkTileVariantsActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022FCC RID: 143308 RVA: 0x0033BA20 File Offset: 0x00339C20
		public ANavigationDataChunkTileVariantsActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ANavigationDataChunkTileVariantsActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008665 RID: 34405
		// (get) Token: 0x06022FCD RID: 143309 RVA: 0x0033BA54 File Offset: 0x00339C54
		// (set) Token: 0x06022FCE RID: 143310 RVA: 0x0033BA8D File Offset: 0x00339C8D
		public TMap<uint, FNavDataLayerActivation> DataLayerActivations
		{
			get
			{
				base.FastCheckIsValid();
				TMap<uint, FNavDataLayerActivation> result;
				if ((result = this._DataLayerActivations) == null)
				{
					result = (this._DataLayerActivations = new TMap<uint, FNavDataLayerActivation>(base.NativePtr + (IntPtr)ANavigationDataChunkTileVariantsActor.__PropertyOffset_DataLayerActivations, this));
				}
				return result;
			}
			set
			{
				this.DataLayerActivations.CopyAssign(value);
			}
		}

		// Token: 0x17008666 RID: 34406
		// (get) Token: 0x06022FCF RID: 143311 RVA: 0x0033BA9C File Offset: 0x00339C9C
		// (set) Token: 0x06022FD0 RID: 143312 RVA: 0x0033BAD5 File Offset: 0x00339CD5
		public TMap<uint, UTileVariantsChunksContainer> LoadedDataChunks
		{
			get
			{
				base.FastCheckIsValid();
				TMap<uint, UTileVariantsChunksContainer> result;
				if ((result = this._LoadedDataChunks) == null)
				{
					result = (this._LoadedDataChunks = new TMap<uint, UTileVariantsChunksContainer>(base.NativePtr + (IntPtr)ANavigationDataChunkTileVariantsActor.__PropertyOffset_LoadedDataChunks, this));
				}
				return result;
			}
			set
			{
				this.LoadedDataChunks.CopyAssign(value);
			}
		}

		// Token: 0x06022FD1 RID: 143313 RVA: 0x0033BAE3 File Offset: 0x00339CE3
		public void OnDataLayerStateChanged(FName DataLayerLabel, EDataLayerState State)
		{
			ANavigationDataChunkTileVariantsActor.__OnDataLayerStateChanged_Internal(base.NativePtr, DataLayerLabel, State);
		}

		// Token: 0x06022FD2 RID: 143314
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnDataLayerStateChanged_Internal(IntPtr @this, FName DataLayerLabel, EDataLayerState State);

		// Token: 0x06022FD3 RID: 143315 RVA: 0x0033BAF2 File Offset: 0x00339CF2
		static ANavigationDataChunkTileVariantsActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavigationDataChunkTileVariantsActor");
		}

		// Token: 0x06022FD4 RID: 143316 RVA: 0x0033BB00 File Offset: 0x00339D00
		protected ANavigationDataChunkTileVariantsActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012AF1 RID: 76529
		public new const string __ObjectPath = "/Script/NavigationSystem.NavigationDataChunkTileVariantsActor";

		// Token: 0x04012AF2 RID: 76530
		private static IntPtr _ClassPtr;

		// Token: 0x04012AF3 RID: 76531
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012AF4 RID: 76532
		internal static int __PropertyOffset_DataLayerActivations;

		// Token: 0x04012AF5 RID: 76533
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<uint, FNavDataLayerActivation> _DataLayerActivations;

		// Token: 0x04012AF6 RID: 76534
		internal static int __PropertyOffset_LoadedDataChunks;

		// Token: 0x04012AF7 RID: 76535
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<uint, UTileVariantsChunksContainer> _LoadedDataChunks;
	}
}

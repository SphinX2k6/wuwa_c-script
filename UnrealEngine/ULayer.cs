using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D1D RID: 3357
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Layer")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class ULayer : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B3F7 RID: 46071 RVA: 0x00100A4B File Offset: 0x000FEC4B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULayer._ClassPtr;
		}

		// Token: 0x0600B3F8 RID: 46072 RVA: 0x00100A58 File Offset: 0x000FEC58
		public ULayer() : this(BuiltinUtils.AllocNativeUObject(ULayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B3F9 RID: 46073 RVA: 0x00100A80 File Offset: 0x000FEC80
		public ULayer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULayer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002925 RID: 10533
		// (get) Token: 0x0600B3FA RID: 46074 RVA: 0x00100AB3 File Offset: 0x000FECB3
		// (set) Token: 0x0600B3FB RID: 46075 RVA: 0x00100AC7 File Offset: 0x000FECC7
		public unsafe FName LayerName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULayer.__PropertyOffset_LayerName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULayer.__PropertyOffset_LayerName) = value;
			}
		}

		// Token: 0x17002926 RID: 10534
		// (get) Token: 0x0600B3FC RID: 46076 RVA: 0x00100ADC File Offset: 0x000FECDC
		// (set) Token: 0x0600B3FD RID: 46077 RVA: 0x00100AF5 File Offset: 0x000FECF5
		public unsafe bool bIsVisible
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULayer.__PropertyOffset_bIsVisible) & ULayer.__PropertyMask_bIsVisible) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULayer.__PropertyOffset_bIsVisible) = ((*(base.NativePtr + (IntPtr)ULayer.__PropertyOffset_bIsVisible) & ~ULayer.__PropertyMask_bIsVisible) | (value ? ULayer.__PropertyMask_bIsVisible : 0));
			}
		}

		// Token: 0x17002927 RID: 10535
		// (get) Token: 0x0600B3FE RID: 46078 RVA: 0x00100B28 File Offset: 0x000FED28
		// (set) Token: 0x0600B3FF RID: 46079 RVA: 0x00100B61 File Offset: 0x000FED61
		public TArray<FLayerActorStats> ActorStats
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLayerActorStats> result;
				if ((result = this._ActorStats) == null)
				{
					result = (this._ActorStats = new TArray<FLayerActorStats>(base.NativePtr + (IntPtr)ULayer.__PropertyOffset_ActorStats, this));
				}
				return result;
			}
			set
			{
				this.ActorStats.CopyAssign(value);
			}
		}

		// Token: 0x0600B400 RID: 46080 RVA: 0x00100B6F File Offset: 0x000FED6F
		static ULayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Layer");
		}

		// Token: 0x0600B401 RID: 46081 RVA: 0x00100B7D File Offset: 0x000FED7D
		protected ULayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005E96 RID: 24214
		public new const string __ObjectPath = "/Script/Engine.Layer";

		// Token: 0x04005E97 RID: 24215
		private static IntPtr _ClassPtr;

		// Token: 0x04005E98 RID: 24216
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005E99 RID: 24217
		internal static int __PropertyOffset_LayerName;

		// Token: 0x04005E9A RID: 24218
		internal static int __PropertyOffset_bIsVisible;

		// Token: 0x04005E9B RID: 24219
		internal static byte __PropertyMask_bIsVisible;

		// Token: 0x04005E9C RID: 24220
		internal static int __PropertyOffset_ActorStats;

		// Token: 0x04005E9D RID: 24221
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLayerActorStats> _ActorStats;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000ED8 RID: 3800
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.NavigationDataChunkActor")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class ANavigationDataChunkActor : APartitionActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CDCD RID: 52685 RVA: 0x0012C085 File Offset: 0x0012A285
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ANavigationDataChunkActor._ClassPtr;
		}

		// Token: 0x0600CDCE RID: 52686 RVA: 0x0012C094 File Offset: 0x0012A294
		public ANavigationDataChunkActor() : this(BuiltinUtils.AllocNativeUObject(ANavigationDataChunkActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CDCF RID: 52687 RVA: 0x0012C0BC File Offset: 0x0012A2BC
		public ANavigationDataChunkActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ANavigationDataChunkActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700306E RID: 12398
		// (get) Token: 0x0600CDD0 RID: 52688 RVA: 0x0012C0F0 File Offset: 0x0012A2F0
		// (set) Token: 0x0600CDD1 RID: 52689 RVA: 0x0012C129 File Offset: 0x0012A329
		public TArray<UNavigationDataChunk> NavDataChunks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UNavigationDataChunk> result;
				if ((result = this._NavDataChunks) == null)
				{
					result = (this._NavDataChunks = new TArray<UNavigationDataChunk>(base.NativePtr + (IntPtr)ANavigationDataChunkActor.__PropertyOffset_NavDataChunks, this));
				}
				return result;
			}
			set
			{
				this.NavDataChunks.CopyAssign(value);
			}
		}

		// Token: 0x1700306F RID: 12399
		// (get) Token: 0x0600CDD2 RID: 52690 RVA: 0x0012C137 File Offset: 0x0012A337
		// (set) Token: 0x0600CDD3 RID: 52691 RVA: 0x0012C14B File Offset: 0x0012A34B
		public unsafe FBox DataChunkActorBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANavigationDataChunkActor.__PropertyOffset_DataChunkActorBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANavigationDataChunkActor.__PropertyOffset_DataChunkActorBounds) = value;
			}
		}

		// Token: 0x17003070 RID: 12400
		// (get) Token: 0x0600CDD4 RID: 52692 RVA: 0x0012C160 File Offset: 0x0012A360
		// (set) Token: 0x0600CDD5 RID: 52693 RVA: 0x0012C174 File Offset: 0x0012A374
		public unsafe FName NavigationDataName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ANavigationDataChunkActor.__PropertyOffset_NavigationDataName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ANavigationDataChunkActor.__PropertyOffset_NavigationDataName) = value;
			}
		}

		// Token: 0x0600CDD6 RID: 52694 RVA: 0x0012C189 File Offset: 0x0012A389
		static ANavigationDataChunkActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.NavigationDataChunkActor");
		}

		// Token: 0x0600CDD7 RID: 52695 RVA: 0x0012C197 File Offset: 0x0012A397
		protected ANavigationDataChunkActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006EE1 RID: 28385
		public new const string __ObjectPath = "/Script/Engine.NavigationDataChunkActor";

		// Token: 0x04006EE2 RID: 28386
		private static IntPtr _ClassPtr;

		// Token: 0x04006EE3 RID: 28387
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006EE4 RID: 28388
		internal static int __PropertyOffset_NavDataChunks;

		// Token: 0x04006EE5 RID: 28389
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNavigationDataChunk> _NavDataChunks;

		// Token: 0x04006EE6 RID: 28390
		internal static int __PropertyOffset_DataChunkActorBounds;

		// Token: 0x04006EE7 RID: 28391
		internal static int __PropertyOffset_NavigationDataName;
	}
}

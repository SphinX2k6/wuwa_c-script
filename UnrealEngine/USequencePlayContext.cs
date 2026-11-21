using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006DB RID: 1755
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.SequencePlayContext")]
	[UnrealStructLayout(424, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 424)]
	public class USequencePlayContext : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600951C RID: 38172 RVA: 0x000E1139 File Offset: 0x000DF339
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USequencePlayContext._ClassPtr;
		}

		// Token: 0x0600951D RID: 38173 RVA: 0x000E1148 File Offset: 0x000DF348
		public USequencePlayContext() : this(BuiltinUtils.AllocNativeUObject(USequencePlayContext.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600951E RID: 38174 RVA: 0x000E1170 File Offset: 0x000DF370
		public USequencePlayContext(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USequencePlayContext.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001BA4 RID: 7076
		// (get) Token: 0x0600951F RID: 38175 RVA: 0x000E11A4 File Offset: 0x000DF3A4
		// (set) Token: 0x06009520 RID: 38176 RVA: 0x000E11DD File Offset: 0x000DF3DD
		public FSequenceInfo PlayInfo
		{
			get
			{
				base.FastCheckIsValid();
				FSequenceInfo result;
				if ((result = this._PlayInfo) == null)
				{
					result = (this._PlayInfo = new FSequenceInfo(base.NativePtr + (IntPtr)USequencePlayContext.__PropertyOffset_PlayInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSequenceInfo.StaticStruct(), base.NativePtr + (IntPtr)USequencePlayContext.__PropertyOffset_PlayInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001BA5 RID: 7077
		// (get) Token: 0x06009521 RID: 38177 RVA: 0x000E11FE File Offset: 0x000DF3FE
		// (set) Token: 0x06009522 RID: 38178 RVA: 0x000E120E File Offset: 0x000DF40E
		public unsafe bool bReverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USequencePlayContext.__PropertyOffset_bReverse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USequencePlayContext.__PropertyOffset_bReverse) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001BA6 RID: 7078
		// (get) Token: 0x06009523 RID: 38179 RVA: 0x000E121F File Offset: 0x000DF41F
		// (set) Token: 0x06009524 RID: 38180 RVA: 0x000E122F File Offset: 0x000DF42F
		public unsafe bool bJumpToLastFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USequencePlayContext.__PropertyOffset_bJumpToLastFrame) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USequencePlayContext.__PropertyOffset_bJumpToLastFrame) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001BA7 RID: 7079
		// (get) Token: 0x06009525 RID: 38181 RVA: 0x000E1240 File Offset: 0x000DF440
		// (set) Token: 0x06009526 RID: 38182 RVA: 0x000E1250 File Offset: 0x000DF450
		public unsafe bool bIsAsync
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USequencePlayContext.__PropertyOffset_bIsAsync) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USequencePlayContext.__PropertyOffset_bIsAsync) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001BA8 RID: 7080
		// (get) Token: 0x06009527 RID: 38183 RVA: 0x000E1264 File Offset: 0x000DF464
		// (set) Token: 0x06009528 RID: 38184 RVA: 0x000E129D File Offset: 0x000DF49D
		public FSimpleSequenceEvent OnLoaded
		{
			get
			{
				base.FastCheckIsValid();
				FSimpleSequenceEvent result;
				if ((result = this._OnLoaded) == null)
				{
					result = (this._OnLoaded = new FSimpleSequenceEvent(base.NativePtr + (IntPtr)USequencePlayContext.__PropertyOffset_OnLoaded, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USequencePlayContext.__PropertyOffset_OnLoaded, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001BA9 RID: 7081
		// (get) Token: 0x06009529 RID: 38185 RVA: 0x000E12C0 File Offset: 0x000DF4C0
		// (set) Token: 0x0600952A RID: 38186 RVA: 0x000E12F9 File Offset: 0x000DF4F9
		public FSimpleSequenceEvent OnPlay
		{
			get
			{
				base.FastCheckIsValid();
				FSimpleSequenceEvent result;
				if ((result = this._OnPlay) == null)
				{
					result = (this._OnPlay = new FSimpleSequenceEvent(base.NativePtr + (IntPtr)USequencePlayContext.__PropertyOffset_OnPlay, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USequencePlayContext.__PropertyOffset_OnPlay, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001BAA RID: 7082
		// (get) Token: 0x0600952B RID: 38187 RVA: 0x000E131C File Offset: 0x000DF51C
		// (set) Token: 0x0600952C RID: 38188 RVA: 0x000E1355 File Offset: 0x000DF555
		public FSimpleSequenceEvent OnFinish
		{
			get
			{
				base.FastCheckIsValid();
				FSimpleSequenceEvent result;
				if ((result = this._OnFinish) == null)
				{
					result = (this._OnFinish = new FSimpleSequenceEvent(base.NativePtr + (IntPtr)USequencePlayContext.__PropertyOffset_OnFinish, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USequencePlayContext.__PropertyOffset_OnFinish, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001BAB RID: 7083
		// (get) Token: 0x0600952D RID: 38189 RVA: 0x000E1378 File Offset: 0x000DF578
		// (set) Token: 0x0600952E RID: 38190 RVA: 0x000E13B1 File Offset: 0x000DF5B1
		public FSimpleSequenceEvent OnPlayReverse
		{
			get
			{
				base.FastCheckIsValid();
				FSimpleSequenceEvent result;
				if ((result = this._OnPlayReverse) == null)
				{
					result = (this._OnPlayReverse = new FSimpleSequenceEvent(base.NativePtr + (IntPtr)USequencePlayContext.__PropertyOffset_OnPlayReverse, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USequencePlayContext.__PropertyOffset_OnPlayReverse, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001BAC RID: 7084
		// (get) Token: 0x0600952F RID: 38191 RVA: 0x000E13D4 File Offset: 0x000DF5D4
		// (set) Token: 0x06009530 RID: 38192 RVA: 0x000E140D File Offset: 0x000DF60D
		public FSimpleSequenceEvent OnStop
		{
			get
			{
				base.FastCheckIsValid();
				FSimpleSequenceEvent result;
				if ((result = this._OnStop) == null)
				{
					result = (this._OnStop = new FSimpleSequenceEvent(base.NativePtr + (IntPtr)USequencePlayContext.__PropertyOffset_OnStop, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USequencePlayContext.__PropertyOffset_OnStop, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001BAD RID: 7085
		// (get) Token: 0x06009531 RID: 38193 RVA: 0x000E1430 File Offset: 0x000DF630
		// (set) Token: 0x06009532 RID: 38194 RVA: 0x000E1469 File Offset: 0x000DF669
		public FSimpleSequenceEvent OnPause
		{
			get
			{
				base.FastCheckIsValid();
				FSimpleSequenceEvent result;
				if ((result = this._OnPause) == null)
				{
					result = (this._OnPause = new FSimpleSequenceEvent(base.NativePtr + (IntPtr)USequencePlayContext.__PropertyOffset_OnPause, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USequencePlayContext.__PropertyOffset_OnPause, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001BAE RID: 7086
		// (get) Token: 0x06009533 RID: 38195 RVA: 0x000E148C File Offset: 0x000DF68C
		// (set) Token: 0x06009534 RID: 38196 RVA: 0x000E14C5 File Offset: 0x000DF6C5
		public FSimpleSequenceEvent OnInterrupt
		{
			get
			{
				base.FastCheckIsValid();
				FSimpleSequenceEvent result;
				if ((result = this._OnInterrupt) == null)
				{
					result = (this._OnInterrupt = new FSimpleSequenceEvent(base.NativePtr + (IntPtr)USequencePlayContext.__PropertyOffset_OnInterrupt, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USequencePlayContext.__PropertyOffset_OnInterrupt, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001BAF RID: 7087
		// (get) Token: 0x06009535 RID: 38197 RVA: 0x000E14E8 File Offset: 0x000DF6E8
		// (set) Token: 0x06009536 RID: 38198 RVA: 0x000E1521 File Offset: 0x000DF721
		public TArray<AUIBaseActor> Roots
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AUIBaseActor> result;
				if ((result = this._Roots) == null)
				{
					result = (this._Roots = new TArray<AUIBaseActor>(base.NativePtr + (IntPtr)USequencePlayContext.__PropertyOffset_Roots, this));
				}
				return result;
			}
			set
			{
				this.Roots.CopyAssign(value);
			}
		}

		// Token: 0x06009537 RID: 38199 RVA: 0x000E152F File Offset: 0x000DF72F
		public void TryStop()
		{
			USequencePlayContext.__TryStop_Internal(base.NativePtr);
		}

		// Token: 0x06009538 RID: 38200 RVA: 0x000E153C File Offset: 0x000DF73C
		public void SetBatchRoots([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AUIBaseActor> BatchRoots)
		{
			USequencePlayContext.__SetBatchRoots_Internal(base.NativePtr, (BatchRoots ?? new TArray<AUIBaseActor>()).NativePtr);
		}

		// Token: 0x06009539 RID: 38201 RVA: 0x000E1559 File Offset: 0x000DF759
		public void ExecutePlay()
		{
			USequencePlayContext.__ExecutePlay_Internal(base.NativePtr);
		}

		// Token: 0x0600953A RID: 38202
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TryStop_Internal(IntPtr @this);

		// Token: 0x0600953B RID: 38203
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBatchRoots_Internal(IntPtr @this, IntPtr BatchRoots);

		// Token: 0x0600953C RID: 38204
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ExecutePlay_Internal(IntPtr @this);

		// Token: 0x0600953D RID: 38205 RVA: 0x000E1566 File Offset: 0x000DF766
		static USequencePlayContext()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.SequencePlayContext");
		}

		// Token: 0x0600953E RID: 38206 RVA: 0x000E1574 File Offset: 0x000DF774
		protected USequencePlayContext(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040040D5 RID: 16597
		public new const string __ObjectPath = "/Script/LGUI.SequencePlayContext";

		// Token: 0x040040D6 RID: 16598
		private static IntPtr _ClassPtr;

		// Token: 0x040040D7 RID: 16599
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040040D8 RID: 16600
		internal static int __PropertyOffset_PlayInfo;

		// Token: 0x040040D9 RID: 16601
		[Nullable(2)]
		private FSequenceInfo _PlayInfo;

		// Token: 0x040040DA RID: 16602
		internal static int __PropertyOffset_bReverse;

		// Token: 0x040040DB RID: 16603
		internal static int __PropertyOffset_bJumpToLastFrame;

		// Token: 0x040040DC RID: 16604
		internal static int __PropertyOffset_bIsAsync;

		// Token: 0x040040DD RID: 16605
		internal static int __PropertyOffset_OnLoaded;

		// Token: 0x040040DE RID: 16606
		[Nullable(2)]
		private FSimpleSequenceEvent _OnLoaded;

		// Token: 0x040040DF RID: 16607
		internal static int __PropertyOffset_OnPlay;

		// Token: 0x040040E0 RID: 16608
		[Nullable(2)]
		private FSimpleSequenceEvent _OnPlay;

		// Token: 0x040040E1 RID: 16609
		internal static int __PropertyOffset_OnFinish;

		// Token: 0x040040E2 RID: 16610
		[Nullable(2)]
		private FSimpleSequenceEvent _OnFinish;

		// Token: 0x040040E3 RID: 16611
		internal static int __PropertyOffset_OnPlayReverse;

		// Token: 0x040040E4 RID: 16612
		[Nullable(2)]
		private FSimpleSequenceEvent _OnPlayReverse;

		// Token: 0x040040E5 RID: 16613
		internal static int __PropertyOffset_OnStop;

		// Token: 0x040040E6 RID: 16614
		[Nullable(2)]
		private FSimpleSequenceEvent _OnStop;

		// Token: 0x040040E7 RID: 16615
		internal static int __PropertyOffset_OnPause;

		// Token: 0x040040E8 RID: 16616
		[Nullable(2)]
		private FSimpleSequenceEvent _OnPause;

		// Token: 0x040040E9 RID: 16617
		internal static int __PropertyOffset_OnInterrupt;

		// Token: 0x040040EA RID: 16618
		[Nullable(2)]
		private FSimpleSequenceEvent _OnInterrupt;

		// Token: 0x040040EB RID: 16619
		internal static int __PropertyOffset_Roots;

		// Token: 0x040040EC RID: 16620
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AUIBaseActor> _Roots;
	}
}

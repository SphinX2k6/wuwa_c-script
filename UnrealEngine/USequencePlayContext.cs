using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002105 RID: 8453
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.SequencePlayContext")]
	[UnrealStructLayout(424, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 424)]
	public class USequencePlayContext : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FCD7 RID: 130263 RVA: 0x002F4BA5 File Offset: 0x002F2DA5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USequencePlayContext._ClassPtr;
		}

		// Token: 0x0601FCD8 RID: 130264 RVA: 0x002F4BB4 File Offset: 0x002F2DB4
		public USequencePlayContext() : this(BuiltinUtils.AllocNativeUObject(USequencePlayContext.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FCD9 RID: 130265 RVA: 0x002F4BDC File Offset: 0x002F2DDC
		public USequencePlayContext(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USequencePlayContext.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007D19 RID: 32025
		// (get) Token: 0x0601FCDA RID: 130266 RVA: 0x002F4C10 File Offset: 0x002F2E10
		// (set) Token: 0x0601FCDB RID: 130267 RVA: 0x002F4C49 File Offset: 0x002F2E49
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

		// Token: 0x17007D1A RID: 32026
		// (get) Token: 0x0601FCDC RID: 130268 RVA: 0x002F4C6A File Offset: 0x002F2E6A
		// (set) Token: 0x0601FCDD RID: 130269 RVA: 0x002F4C7A File Offset: 0x002F2E7A
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

		// Token: 0x17007D1B RID: 32027
		// (get) Token: 0x0601FCDE RID: 130270 RVA: 0x002F4C8B File Offset: 0x002F2E8B
		// (set) Token: 0x0601FCDF RID: 130271 RVA: 0x002F4C9B File Offset: 0x002F2E9B
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

		// Token: 0x17007D1C RID: 32028
		// (get) Token: 0x0601FCE0 RID: 130272 RVA: 0x002F4CAC File Offset: 0x002F2EAC
		// (set) Token: 0x0601FCE1 RID: 130273 RVA: 0x002F4CBC File Offset: 0x002F2EBC
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

		// Token: 0x17007D1D RID: 32029
		// (get) Token: 0x0601FCE2 RID: 130274 RVA: 0x002F4CD0 File Offset: 0x002F2ED0
		// (set) Token: 0x0601FCE3 RID: 130275 RVA: 0x002F4D09 File Offset: 0x002F2F09
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

		// Token: 0x17007D1E RID: 32030
		// (get) Token: 0x0601FCE4 RID: 130276 RVA: 0x002F4D2C File Offset: 0x002F2F2C
		// (set) Token: 0x0601FCE5 RID: 130277 RVA: 0x002F4D65 File Offset: 0x002F2F65
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

		// Token: 0x17007D1F RID: 32031
		// (get) Token: 0x0601FCE6 RID: 130278 RVA: 0x002F4D88 File Offset: 0x002F2F88
		// (set) Token: 0x0601FCE7 RID: 130279 RVA: 0x002F4DC1 File Offset: 0x002F2FC1
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

		// Token: 0x17007D20 RID: 32032
		// (get) Token: 0x0601FCE8 RID: 130280 RVA: 0x002F4DE4 File Offset: 0x002F2FE4
		// (set) Token: 0x0601FCE9 RID: 130281 RVA: 0x002F4E1D File Offset: 0x002F301D
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

		// Token: 0x17007D21 RID: 32033
		// (get) Token: 0x0601FCEA RID: 130282 RVA: 0x002F4E40 File Offset: 0x002F3040
		// (set) Token: 0x0601FCEB RID: 130283 RVA: 0x002F4E79 File Offset: 0x002F3079
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

		// Token: 0x17007D22 RID: 32034
		// (get) Token: 0x0601FCEC RID: 130284 RVA: 0x002F4E9C File Offset: 0x002F309C
		// (set) Token: 0x0601FCED RID: 130285 RVA: 0x002F4ED5 File Offset: 0x002F30D5
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

		// Token: 0x17007D23 RID: 32035
		// (get) Token: 0x0601FCEE RID: 130286 RVA: 0x002F4EF8 File Offset: 0x002F30F8
		// (set) Token: 0x0601FCEF RID: 130287 RVA: 0x002F4F31 File Offset: 0x002F3131
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

		// Token: 0x17007D24 RID: 32036
		// (get) Token: 0x0601FCF0 RID: 130288 RVA: 0x002F4F54 File Offset: 0x002F3154
		// (set) Token: 0x0601FCF1 RID: 130289 RVA: 0x002F4F8D File Offset: 0x002F318D
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

		// Token: 0x0601FCF2 RID: 130290 RVA: 0x002F4F9B File Offset: 0x002F319B
		public void TryStop()
		{
			USequencePlayContext.__TryStop_Internal(base.NativePtr);
		}

		// Token: 0x0601FCF3 RID: 130291 RVA: 0x002F4FA8 File Offset: 0x002F31A8
		public void SetBatchRoots([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AUIBaseActor> BatchRoots)
		{
			USequencePlayContext.__SetBatchRoots_Internal(base.NativePtr, (BatchRoots ?? new TArray<AUIBaseActor>()).NativePtr);
		}

		// Token: 0x0601FCF4 RID: 130292 RVA: 0x002F4FC5 File Offset: 0x002F31C5
		public void ExecutePlay()
		{
			USequencePlayContext.__ExecutePlay_Internal(base.NativePtr);
		}

		// Token: 0x0601FCF5 RID: 130293
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TryStop_Internal(IntPtr @this);

		// Token: 0x0601FCF6 RID: 130294
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBatchRoots_Internal(IntPtr @this, IntPtr BatchRoots);

		// Token: 0x0601FCF7 RID: 130295
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ExecutePlay_Internal(IntPtr @this);

		// Token: 0x0601FCF8 RID: 130296 RVA: 0x002F4FD2 File Offset: 0x002F31D2
		static USequencePlayContext()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.SequencePlayContext");
		}

		// Token: 0x0601FCF9 RID: 130297 RVA: 0x002F4FE0 File Offset: 0x002F31E0
		protected USequencePlayContext(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011237 RID: 70199
		public new const string __ObjectPath = "/Script/LGUI.SequencePlayContext";

		// Token: 0x04011238 RID: 70200
		private static IntPtr _ClassPtr;

		// Token: 0x04011239 RID: 70201
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401123A RID: 70202
		internal static int __PropertyOffset_PlayInfo;

		// Token: 0x0401123B RID: 70203
		[Nullable(2)]
		private FSequenceInfo _PlayInfo;

		// Token: 0x0401123C RID: 70204
		internal static int __PropertyOffset_bReverse;

		// Token: 0x0401123D RID: 70205
		internal static int __PropertyOffset_bJumpToLastFrame;

		// Token: 0x0401123E RID: 70206
		internal static int __PropertyOffset_bIsAsync;

		// Token: 0x0401123F RID: 70207
		internal static int __PropertyOffset_OnLoaded;

		// Token: 0x04011240 RID: 70208
		[Nullable(2)]
		private FSimpleSequenceEvent _OnLoaded;

		// Token: 0x04011241 RID: 70209
		internal static int __PropertyOffset_OnPlay;

		// Token: 0x04011242 RID: 70210
		[Nullable(2)]
		private FSimpleSequenceEvent _OnPlay;

		// Token: 0x04011243 RID: 70211
		internal static int __PropertyOffset_OnFinish;

		// Token: 0x04011244 RID: 70212
		[Nullable(2)]
		private FSimpleSequenceEvent _OnFinish;

		// Token: 0x04011245 RID: 70213
		internal static int __PropertyOffset_OnPlayReverse;

		// Token: 0x04011246 RID: 70214
		[Nullable(2)]
		private FSimpleSequenceEvent _OnPlayReverse;

		// Token: 0x04011247 RID: 70215
		internal static int __PropertyOffset_OnStop;

		// Token: 0x04011248 RID: 70216
		[Nullable(2)]
		private FSimpleSequenceEvent _OnStop;

		// Token: 0x04011249 RID: 70217
		internal static int __PropertyOffset_OnPause;

		// Token: 0x0401124A RID: 70218
		[Nullable(2)]
		private FSimpleSequenceEvent _OnPause;

		// Token: 0x0401124B RID: 70219
		internal static int __PropertyOffset_OnInterrupt;

		// Token: 0x0401124C RID: 70220
		[Nullable(2)]
		private FSimpleSequenceEvent _OnInterrupt;

		// Token: 0x0401124D RID: 70221
		internal static int __PropertyOffset_Roots;

		// Token: 0x0401124E RID: 70222
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AUIBaseActor> _Roots;
	}
}

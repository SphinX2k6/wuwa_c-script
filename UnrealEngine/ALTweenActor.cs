using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200223A RID: 8762
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LTween.LTweenActor")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1128)]
	public class ALTweenActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021558 RID: 136536 RVA: 0x00311F44 File Offset: 0x00310144
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALTweenActor._ClassPtr;
		}

		// Token: 0x06021559 RID: 136537 RVA: 0x00311F50 File Offset: 0x00310150
		public ALTweenActor() : this(BuiltinUtils.AllocNativeUObject(ALTweenActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602155A RID: 136538 RVA: 0x00311F78 File Offset: 0x00310178
		public ALTweenActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALTweenActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008210 RID: 33296
		// (get) Token: 0x0602155B RID: 136539 RVA: 0x00311FAC File Offset: 0x003101AC
		// (set) Token: 0x0602155C RID: 136540 RVA: 0x00311FE5 File Offset: 0x003101E5
		public TArray<ULTweener> tweenerList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULTweener> result;
				if ((result = this._tweenerList) == null)
				{
					result = (this._tweenerList = new TArray<ULTweener>(base.NativePtr + (IntPtr)ALTweenActor.__PropertyOffset_tweenerList, this));
				}
				return result;
			}
			set
			{
				this.tweenerList.CopyAssign(value);
			}
		}

		// Token: 0x17008211 RID: 33297
		// (get) Token: 0x0602155D RID: 136541 RVA: 0x00311FF4 File Offset: 0x003101F4
		// (set) Token: 0x0602155E RID: 136542 RVA: 0x0031202D File Offset: 0x0031022D
		public TArray<ULTweener> reserveTweenerList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULTweener> result;
				if ((result = this._reserveTweenerList) == null)
				{
					result = (this._reserveTweenerList = new TArray<ULTweener>(base.NativePtr + (IntPtr)ALTweenActor.__PropertyOffset_reserveTweenerList, this));
				}
				return result;
			}
			set
			{
				this.reserveTweenerList.CopyAssign(value);
			}
		}

		// Token: 0x17008212 RID: 33298
		// (get) Token: 0x0602155F RID: 136543 RVA: 0x0031203B File Offset: 0x0031023B
		// (set) Token: 0x06021560 RID: 136544 RVA: 0x0031204B File Offset: 0x0031024B
		public unsafe float GlobalPlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALTweenActor.__PropertyOffset_GlobalPlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALTweenActor.__PropertyOffset_GlobalPlayRate) = value;
			}
		}

		// Token: 0x06021561 RID: 136545 RVA: 0x0031205C File Offset: 0x0031025C
		public void SetGlobalPlayRate(float NewPlayRate)
		{
			ALTweenActor.__SetGlobalPlayRate_Internal(base.NativePtr, NewPlayRate);
		}

		// Token: 0x06021562 RID: 136546 RVA: 0x0031206A File Offset: 0x0031026A
		public void KillAllTweens(bool callComplete = false)
		{
			ALTweenActor.__KillAllTweens_Internal(base.NativePtr, callComplete);
		}

		// Token: 0x06021563 RID: 136547 RVA: 0x00312078 File Offset: 0x00310278
		[NullableContext(2)]
		public static ALTweenActor GetLTweenInstance(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ALTweenActor>(ALTweenActor.__GetLTweenInstance_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06021564 RID: 136548 RVA: 0x00312094 File Offset: 0x00310294
		public float GetGlobalPlayRate()
		{
			return ALTweenActor.__GetGlobalPlayRate_Internal(base.NativePtr);
		}

		// Token: 0x06021565 RID: 136549 RVA: 0x003120A1 File Offset: 0x003102A1
		public void EnableTick()
		{
			ALTweenActor.__EnableTick_Internal(base.NativePtr);
		}

		// Token: 0x06021566 RID: 136550 RVA: 0x003120AE File Offset: 0x003102AE
		public void DisableTick()
		{
			ALTweenActor.__DisableTick_Internal(base.NativePtr);
		}

		// Token: 0x06021567 RID: 136551 RVA: 0x003120BB File Offset: 0x003102BB
		public void CustomTick(float DeltaTime)
		{
			ALTweenActor.__CustomTick_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x06021568 RID: 136552
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGlobalPlayRate_Internal(IntPtr @this, float NewPlayRate);

		// Token: 0x06021569 RID: 136553
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KillAllTweens_Internal(IntPtr @this, bool callComplete);

		// Token: 0x0602156A RID: 136554
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLTweenInstance_Internal(IntPtr WorldContextObject);

		// Token: 0x0602156B RID: 136555
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGlobalPlayRate_Internal(IntPtr @this);

		// Token: 0x0602156C RID: 136556
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableTick_Internal(IntPtr @this);

		// Token: 0x0602156D RID: 136557
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DisableTick_Internal(IntPtr @this);

		// Token: 0x0602156E RID: 136558
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CustomTick_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x0602156F RID: 136559 RVA: 0x003120C9 File Offset: 0x003102C9
		static ALTweenActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LTween.LTweenActor");
		}

		// Token: 0x06021570 RID: 136560 RVA: 0x003120D7 File Offset: 0x003102D7
		protected ALTweenActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011C6D RID: 72813
		public new const string __ObjectPath = "/Script/LTween.LTweenActor";

		// Token: 0x04011C6E RID: 72814
		private static IntPtr _ClassPtr;

		// Token: 0x04011C6F RID: 72815
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011C70 RID: 72816
		internal static int __PropertyOffset_tweenerList;

		// Token: 0x04011C71 RID: 72817
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULTweener> _tweenerList;

		// Token: 0x04011C72 RID: 72818
		internal static int __PropertyOffset_reserveTweenerList;

		// Token: 0x04011C73 RID: 72819
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULTweener> _reserveTweenerList;

		// Token: 0x04011C74 RID: 72820
		internal static int __PropertyOffset_GlobalPlayRate;
	}
}

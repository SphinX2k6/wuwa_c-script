using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002096 RID: 8342
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIPlayTweenSequenceComponent")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class ULGUIPlayTweenSequenceComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F76F RID: 128879 RVA: 0x002EBE78 File Offset: 0x002EA078
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIPlayTweenSequenceComponent._ClassPtr;
		}

		// Token: 0x0601F770 RID: 128880 RVA: 0x002EBE84 File Offset: 0x002EA084
		public ULGUIPlayTweenSequenceComponent() : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTweenSequenceComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F771 RID: 128881 RVA: 0x002EBEAC File Offset: 0x002EA0AC
		public ULGUIPlayTweenSequenceComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTweenSequenceComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007C1E RID: 31774
		// (get) Token: 0x0601F772 RID: 128882 RVA: 0x002EBEDF File Offset: 0x002EA0DF
		// (set) Token: 0x0601F773 RID: 128883 RVA: 0x002EBEEF File Offset: 0x002EA0EF
		public unsafe bool playOnStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTweenSequenceComponent.__PropertyOffset_playOnStart) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTweenSequenceComponent.__PropertyOffset_playOnStart) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007C1F RID: 31775
		// (get) Token: 0x0601F774 RID: 128884 RVA: 0x002EBF00 File Offset: 0x002EA100
		// (set) Token: 0x0601F775 RID: 128885 RVA: 0x002EBF39 File Offset: 0x002EA139
		public TArray<ULGUIPlayTween> playTweenArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULGUIPlayTween> result;
				if ((result = this._playTweenArray) == null)
				{
					result = (this._playTweenArray = new TArray<ULGUIPlayTween>(base.NativePtr + (IntPtr)ULGUIPlayTweenSequenceComponent.__PropertyOffset_playTweenArray, this));
				}
				return result;
			}
			set
			{
				this.playTweenArray.CopyAssign(value);
			}
		}

		// Token: 0x17007C20 RID: 31776
		// (get) Token: 0x0601F776 RID: 128886 RVA: 0x002EBF48 File Offset: 0x002EA148
		// (set) Token: 0x0601F777 RID: 128887 RVA: 0x002EBF81 File Offset: 0x002EA181
		public FLGUIDrawableEvent onComplete
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._onComplete) == null)
				{
					result = (this._onComplete = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)ULGUIPlayTweenSequenceComponent.__PropertyOffset_onComplete, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)ULGUIPlayTweenSequenceComponent.__PropertyOffset_onComplete, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601F778 RID: 128888 RVA: 0x002EBFA2 File Offset: 0x002EA1A2
		public void Stop()
		{
			ULGUIPlayTweenSequenceComponent.__Stop_Internal(base.NativePtr);
		}

		// Token: 0x0601F779 RID: 128889 RVA: 0x002EBFAF File Offset: 0x002EA1AF
		public void Play()
		{
			ULGUIPlayTweenSequenceComponent.__Play_Internal(base.NativePtr);
		}

		// Token: 0x0601F77A RID: 128890
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this);

		// Token: 0x0601F77B RID: 128891
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Play_Internal(IntPtr @this);

		// Token: 0x0601F77C RID: 128892 RVA: 0x002EBFBC File Offset: 0x002EA1BC
		static ULGUIPlayTweenSequenceComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIPlayTweenSequenceComponent");
		}

		// Token: 0x0601F77D RID: 128893 RVA: 0x002EBFCA File Offset: 0x002EA1CA
		protected ULGUIPlayTweenSequenceComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010FD2 RID: 69586
		public new const string __ObjectPath = "/Script/LGUI.LGUIPlayTweenSequenceComponent";

		// Token: 0x04010FD3 RID: 69587
		private static IntPtr _ClassPtr;

		// Token: 0x04010FD4 RID: 69588
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010FD5 RID: 69589
		internal static int __PropertyOffset_playOnStart;

		// Token: 0x04010FD6 RID: 69590
		internal static int __PropertyOffset_playTweenArray;

		// Token: 0x04010FD7 RID: 69591
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULGUIPlayTween> _playTweenArray;

		// Token: 0x04010FD8 RID: 69592
		internal static int __PropertyOffset_onComplete;

		// Token: 0x04010FD9 RID: 69593
		[Nullable(2)]
		private FLGUIDrawableEvent _onComplete;
	}
}

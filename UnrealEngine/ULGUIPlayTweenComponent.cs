using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006AC RID: 1708
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIPlayTweenComponent")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class ULGUIPlayTweenComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060092B8 RID: 37560 RVA: 0x000DD0BA File Offset: 0x000DB2BA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIPlayTweenComponent._ClassPtr;
		}

		// Token: 0x060092B9 RID: 37561 RVA: 0x000DD0C8 File Offset: 0x000DB2C8
		public ULGUIPlayTweenComponent() : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTweenComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060092BA RID: 37562 RVA: 0x000DD0F0 File Offset: 0x000DB2F0
		[NullableContext(1)]
		public ULGUIPlayTweenComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTweenComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B5B RID: 7003
		// (get) Token: 0x060092BB RID: 37563 RVA: 0x000DD123 File Offset: 0x000DB323
		// (set) Token: 0x060092BC RID: 37564 RVA: 0x000DD133 File Offset: 0x000DB333
		public unsafe bool playOnStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTweenComponent.__PropertyOffset_playOnStart) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTweenComponent.__PropertyOffset_playOnStart) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B5C RID: 7004
		// (get) Token: 0x060092BD RID: 37565 RVA: 0x000DD144 File Offset: 0x000DB344
		// (set) Token: 0x060092BE RID: 37566 RVA: 0x000DD158 File Offset: 0x000DB358
		public unsafe ULGUIPlayTween playTween
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUIPlayTween>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIPlayTweenComponent.__PropertyOffset_playTween);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIPlayTweenComponent.__PropertyOffset_playTween, value);
			}
		}

		// Token: 0x17001B5D RID: 7005
		// (get) Token: 0x060092BF RID: 37567 RVA: 0x000DD16D File Offset: 0x000DB36D
		// (set) Token: 0x060092C0 RID: 37568 RVA: 0x000DD17D File Offset: 0x000DB37D
		public unsafe bool activeOptimized
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTweenComponent.__PropertyOffset_activeOptimized) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTweenComponent.__PropertyOffset_activeOptimized) = (value ? 1 : 0);
			}
		}

		// Token: 0x060092C1 RID: 37569 RVA: 0x000DD18E File Offset: 0x000DB38E
		public void Stop()
		{
			ULGUIPlayTweenComponent.__Stop_Internal(base.NativePtr);
		}

		// Token: 0x060092C2 RID: 37570 RVA: 0x000DD19B File Offset: 0x000DB39B
		public void Resume()
		{
			ULGUIPlayTweenComponent.__Resume_Internal(base.NativePtr);
		}

		// Token: 0x060092C3 RID: 37571 RVA: 0x000DD1A8 File Offset: 0x000DB3A8
		public void Play()
		{
			ULGUIPlayTweenComponent.__Play_Internal(base.NativePtr);
		}

		// Token: 0x060092C4 RID: 37572 RVA: 0x000DD1B5 File Offset: 0x000DB3B5
		public void Pause()
		{
			ULGUIPlayTweenComponent.__Pause_Internal(base.NativePtr);
		}

		// Token: 0x060092C5 RID: 37573 RVA: 0x000DD1C2 File Offset: 0x000DB3C2
		public ULGUIPlayTween GetPlayTween()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPlayTween>(ULGUIPlayTweenComponent.__GetPlayTween_Internal(base.NativePtr));
		}

		// Token: 0x060092C6 RID: 37574
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this);

		// Token: 0x060092C7 RID: 37575
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Resume_Internal(IntPtr @this);

		// Token: 0x060092C8 RID: 37576
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Play_Internal(IntPtr @this);

		// Token: 0x060092C9 RID: 37577
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Pause_Internal(IntPtr @this);

		// Token: 0x060092CA RID: 37578
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPlayTween_Internal(IntPtr @this);

		// Token: 0x060092CB RID: 37579 RVA: 0x000DD1D4 File Offset: 0x000DB3D4
		static ULGUIPlayTweenComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIPlayTweenComponent");
		}

		// Token: 0x060092CC RID: 37580 RVA: 0x000DD1E2 File Offset: 0x000DB3E2
		protected ULGUIPlayTweenComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003FF4 RID: 16372
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIPlayTweenComponent";

		// Token: 0x04003FF5 RID: 16373
		private static IntPtr _ClassPtr;

		// Token: 0x04003FF6 RID: 16374
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003FF7 RID: 16375
		internal static int __PropertyOffset_playOnStart;

		// Token: 0x04003FF8 RID: 16376
		internal static int __PropertyOffset_playTween;

		// Token: 0x04003FF9 RID: 16377
		internal static int __PropertyOffset_activeOptimized;
	}
}

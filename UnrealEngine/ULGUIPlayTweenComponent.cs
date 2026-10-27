using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002095 RID: 8341
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIPlayTweenComponent")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class ULGUIPlayTweenComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F758 RID: 128856 RVA: 0x002EBD1E File Offset: 0x002E9F1E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIPlayTweenComponent._ClassPtr;
		}

		// Token: 0x0601F759 RID: 128857 RVA: 0x002EBD2C File Offset: 0x002E9F2C
		public ULGUIPlayTweenComponent() : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTweenComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F75A RID: 128858 RVA: 0x002EBD54 File Offset: 0x002E9F54
		[NullableContext(1)]
		public ULGUIPlayTweenComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTweenComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007C1A RID: 31770
		// (get) Token: 0x0601F75B RID: 128859 RVA: 0x002EBD87 File Offset: 0x002E9F87
		// (set) Token: 0x0601F75C RID: 128860 RVA: 0x002EBD97 File Offset: 0x002E9F97
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

		// Token: 0x17007C1B RID: 31771
		// (get) Token: 0x0601F75D RID: 128861 RVA: 0x002EBDA8 File Offset: 0x002E9FA8
		// (set) Token: 0x0601F75E RID: 128862 RVA: 0x002EBDBC File Offset: 0x002E9FBC
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

		// Token: 0x17007C1C RID: 31772
		// (get) Token: 0x0601F75F RID: 128863 RVA: 0x002EBDD1 File Offset: 0x002E9FD1
		// (set) Token: 0x0601F760 RID: 128864 RVA: 0x002EBDE1 File Offset: 0x002E9FE1
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

		// Token: 0x17007C1D RID: 31773
		// (get) Token: 0x0601F761 RID: 128865 RVA: 0x002EBDF2 File Offset: 0x002E9FF2
		// (set) Token: 0x0601F762 RID: 128866 RVA: 0x002EBE06 File Offset: 0x002EA006
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UPlayTweenActiveOpt> ControllerComp
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTweenComponent.__PropertyOffset_ControllerComp);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTweenComponent.__PropertyOffset_ControllerComp) = value;
			}
		}

		// Token: 0x0601F763 RID: 128867 RVA: 0x002EBE1B File Offset: 0x002EA01B
		public void Stop()
		{
			ULGUIPlayTweenComponent.__Stop_Internal(base.NativePtr);
		}

		// Token: 0x0601F764 RID: 128868 RVA: 0x002EBE28 File Offset: 0x002EA028
		public void Resume()
		{
			ULGUIPlayTweenComponent.__Resume_Internal(base.NativePtr);
		}

		// Token: 0x0601F765 RID: 128869 RVA: 0x002EBE35 File Offset: 0x002EA035
		public void Play()
		{
			ULGUIPlayTweenComponent.__Play_Internal(base.NativePtr);
		}

		// Token: 0x0601F766 RID: 128870 RVA: 0x002EBE42 File Offset: 0x002EA042
		public void Pause()
		{
			ULGUIPlayTweenComponent.__Pause_Internal(base.NativePtr);
		}

		// Token: 0x0601F767 RID: 128871 RVA: 0x002EBE4F File Offset: 0x002EA04F
		public ULGUIPlayTween GetPlayTween()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPlayTween>(ULGUIPlayTweenComponent.__GetPlayTween_Internal(base.NativePtr));
		}

		// Token: 0x0601F768 RID: 128872
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this);

		// Token: 0x0601F769 RID: 128873
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Resume_Internal(IntPtr @this);

		// Token: 0x0601F76A RID: 128874
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Play_Internal(IntPtr @this);

		// Token: 0x0601F76B RID: 128875
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Pause_Internal(IntPtr @this);

		// Token: 0x0601F76C RID: 128876
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPlayTween_Internal(IntPtr @this);

		// Token: 0x0601F76D RID: 128877 RVA: 0x002EBE61 File Offset: 0x002EA061
		static ULGUIPlayTweenComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIPlayTweenComponent");
		}

		// Token: 0x0601F76E RID: 128878 RVA: 0x002EBE6F File Offset: 0x002EA06F
		protected ULGUIPlayTweenComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010FCB RID: 69579
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIPlayTweenComponent";

		// Token: 0x04010FCC RID: 69580
		private static IntPtr _ClassPtr;

		// Token: 0x04010FCD RID: 69581
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010FCE RID: 69582
		internal static int __PropertyOffset_playOnStart;

		// Token: 0x04010FCF RID: 69583
		internal static int __PropertyOffset_playTween;

		// Token: 0x04010FD0 RID: 69584
		internal static int __PropertyOffset_activeOptimized;

		// Token: 0x04010FD1 RID: 69585
		internal static int __PropertyOffset_ControllerComp;
	}
}

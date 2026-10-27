using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002024 RID: 8228
	[UnrealObjectPath("/Script/LGUI.LGUIBaseRayEmitter")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public abstract class ULGUIBaseRayEmitter : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EFEA RID: 126954 RVA: 0x002E16D5 File Offset: 0x002DF8D5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIBaseRayEmitter._ClassPtr;
		}

		// Token: 0x17007B59 RID: 31577
		// (get) Token: 0x0601EFEB RID: 126955 RVA: 0x002E16E1 File Offset: 0x002DF8E1
		// (set) Token: 0x0601EFEC RID: 126956 RVA: 0x002E16F1 File Offset: 0x002DF8F1
		public unsafe float clickThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIBaseRayEmitter.__PropertyOffset_clickThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIBaseRayEmitter.__PropertyOffset_clickThreshold) = value;
			}
		}

		// Token: 0x17007B5A RID: 31578
		// (get) Token: 0x0601EFED RID: 126957 RVA: 0x002E1702 File Offset: 0x002DF902
		// (set) Token: 0x0601EFEE RID: 126958 RVA: 0x002E1712 File Offset: 0x002DF912
		public unsafe bool holdToDrag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIBaseRayEmitter.__PropertyOffset_holdToDrag) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIBaseRayEmitter.__PropertyOffset_holdToDrag) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007B5B RID: 31579
		// (get) Token: 0x0601EFEF RID: 126959 RVA: 0x002E1723 File Offset: 0x002DF923
		// (set) Token: 0x0601EFF0 RID: 126960 RVA: 0x002E1733 File Offset: 0x002DF933
		public unsafe float holdToDragTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIBaseRayEmitter.__PropertyOffset_holdToDragTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIBaseRayEmitter.__PropertyOffset_holdToDragTime) = value;
			}
		}

		// Token: 0x0601EFF1 RID: 126961 RVA: 0x002E1744 File Offset: 0x002DF944
		public void SetInitialValue(float InClickThreshold, bool InHoldToDrag, float InHoldToDragTime)
		{
			ULGUIBaseRayEmitter.__SetInitialValue_Internal(base.NativePtr, InClickThreshold, InHoldToDrag, InHoldToDragTime);
		}

		// Token: 0x0601EFF2 RID: 126962 RVA: 0x002E1754 File Offset: 0x002DF954
		public void SetClickThreshold(float value)
		{
			ULGUIBaseRayEmitter.__SetClickThreshold_Internal(base.NativePtr, value);
		}

		// Token: 0x0601EFF3 RID: 126963 RVA: 0x002E1764 File Offset: 0x002DF964
		public unsafe void GetInitialValue(ref float OutClickThreshold, ref bool OutHoldToDrag, ref float OutHoldToDragTime)
		{
			fixed (float* ptr = &OutClickThreshold)
			{
				void* ptr2 = (void*)ptr;
				fixed (bool* ptr3 = &OutHoldToDrag)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &OutHoldToDragTime)
					{
						void* ptr6 = (void*)ptr5;
						ULGUIBaseRayEmitter.__GetInitialValue_Internal(base.NativePtr, ref OutClickThreshold, ref OutHoldToDrag, ref OutHoldToDragTime);
						ptr = null;
						ptr3 = null;
					}
				}
			}
		}

		// Token: 0x0601EFF4 RID: 126964 RVA: 0x002E179D File Offset: 0x002DF99D
		public float GetClickThreshold()
		{
			return ULGUIBaseRayEmitter.__GetClickThreshold_Internal(base.NativePtr);
		}

		// Token: 0x0601EFF5 RID: 126965
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInitialValue_Internal(IntPtr @this, float InClickThreshold, bool InHoldToDrag, float InHoldToDragTime);

		// Token: 0x0601EFF6 RID: 126966
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClickThreshold_Internal(IntPtr @this, float value);

		// Token: 0x0601EFF7 RID: 126967
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetInitialValue_Internal(IntPtr @this, ref float OutClickThreshold, ref bool OutHoldToDrag, ref float OutHoldToDragTime);

		// Token: 0x0601EFF8 RID: 126968
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetClickThreshold_Internal(IntPtr @this);

		// Token: 0x0601EFF9 RID: 126969 RVA: 0x002E17AA File Offset: 0x002DF9AA
		static ULGUIBaseRayEmitter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIBaseRayEmitter");
		}

		// Token: 0x0601EFFA RID: 126970 RVA: 0x002E17B8 File Offset: 0x002DF9B8
		protected ULGUIBaseRayEmitter() : this(BuiltinUtils.AllocNativeUObject(ULGUIBaseRayEmitter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EFFB RID: 126971 RVA: 0x002E17E0 File Offset: 0x002DF9E0
		protected ULGUIBaseRayEmitter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010D91 RID: 69009
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIBaseRayEmitter";

		// Token: 0x04010D92 RID: 69010
		private static IntPtr _ClassPtr;

		// Token: 0x04010D93 RID: 69011
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010D94 RID: 69012
		internal static int __PropertyOffset_clickThreshold;

		// Token: 0x04010D95 RID: 69013
		internal static int __PropertyOffset_holdToDrag;

		// Token: 0x04010D96 RID: 69014
		internal static int __PropertyOffset_holdToDragTime;
	}
}

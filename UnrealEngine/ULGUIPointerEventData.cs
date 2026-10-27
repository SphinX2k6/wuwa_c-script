using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020A7 RID: 8359
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIPointerEventData")]
	[UnrealStructLayout(512, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 512)]
	public class ULGUIPointerEventData : ULGUIBaseEventData, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F806 RID: 129030 RVA: 0x002ED38E File Offset: 0x002EB58E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIPointerEventData._ClassPtr;
		}

		// Token: 0x0601F807 RID: 129031 RVA: 0x002ED39C File Offset: 0x002EB59C
		public ULGUIPointerEventData() : this(BuiltinUtils.AllocNativeUObject(ULGUIPointerEventData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F808 RID: 129032 RVA: 0x002ED3C4 File Offset: 0x002EB5C4
		[NullableContext(1)]
		public ULGUIPointerEventData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIPointerEventData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007C3C RID: 31804
		// (get) Token: 0x0601F809 RID: 129033 RVA: 0x002ED3F7 File Offset: 0x002EB5F7
		// (set) Token: 0x0601F80A RID: 129034 RVA: 0x002ED407 File Offset: 0x002EB607
		public unsafe ELGUIPointerInputType inputType
		{
			get
			{
				return (ELGUIPointerInputType)(*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_inputType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_inputType) = (byte)value;
			}
		}

		// Token: 0x17007C3D RID: 31805
		// (get) Token: 0x0601F80B RID: 129035 RVA: 0x002ED418 File Offset: 0x002EB618
		// (set) Token: 0x0601F80C RID: 129036 RVA: 0x002ED428 File Offset: 0x002EB628
		public unsafe int pointerID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_pointerID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_pointerID) = value;
			}
		}

		// Token: 0x17007C3E RID: 31806
		// (get) Token: 0x0601F80D RID: 129037 RVA: 0x002ED439 File Offset: 0x002EB639
		// (set) Token: 0x0601F80E RID: 129038 RVA: 0x002ED44D File Offset: 0x002EB64D
		public unsafe FVector pointerPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_pointerPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_pointerPosition) = value;
			}
		}

		// Token: 0x17007C3F RID: 31807
		// (get) Token: 0x0601F80F RID: 129039 RVA: 0x002ED462 File Offset: 0x002EB662
		// (set) Token: 0x0601F810 RID: 129040 RVA: 0x002ED476 File Offset: 0x002EB676
		public unsafe USceneComponent currentComponent_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIPointerEventData.__PropertyOffset_currentComponent_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIPointerEventData.__PropertyOffset_currentComponent_DEPRECATED, value);
			}
		}

		// Token: 0x17007C40 RID: 31808
		// (get) Token: 0x0601F811 RID: 129041 RVA: 0x002ED48B File Offset: 0x002EB68B
		// (set) Token: 0x0601F812 RID: 129042 RVA: 0x002ED49F File Offset: 0x002EB69F
		public unsafe USceneComponent enterComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIPointerEventData.__PropertyOffset_enterComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIPointerEventData.__PropertyOffset_enterComponent, value);
			}
		}

		// Token: 0x17007C41 RID: 31809
		// (get) Token: 0x0601F813 RID: 129043 RVA: 0x002ED4B4 File Offset: 0x002EB6B4
		// (set) Token: 0x0601F814 RID: 129044 RVA: 0x002ED4ED File Offset: 0x002EB6ED
		[Nullable(1)]
		public TArray<USceneComponent> enterComponentStack
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<USceneComponent> result;
				if ((result = this._enterComponentStack) == null)
				{
					result = (this._enterComponentStack = new TArray<USceneComponent>(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_enterComponentStack, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.enterComponentStack.CopyAssign(value);
			}
		}

		// Token: 0x17007C42 RID: 31810
		// (get) Token: 0x0601F815 RID: 129045 RVA: 0x002ED4FC File Offset: 0x002EB6FC
		// (set) Token: 0x0601F816 RID: 129046 RVA: 0x002ED535 File Offset: 0x002EB735
		[Nullable(1)]
		public TArray<USceneComponent> hoverComponentArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<USceneComponent> result;
				if ((result = this._hoverComponentArray) == null)
				{
					result = (this._hoverComponentArray = new TArray<USceneComponent>(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_hoverComponentArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.hoverComponentArray.CopyAssign(value);
			}
		}

		// Token: 0x17007C43 RID: 31811
		// (get) Token: 0x0601F817 RID: 129047 RVA: 0x002ED543 File Offset: 0x002EB743
		// (set) Token: 0x0601F818 RID: 129048 RVA: 0x002ED557 File Offset: 0x002EB757
		public unsafe FVector worldPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_worldPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_worldPoint) = value;
			}
		}

		// Token: 0x17007C44 RID: 31812
		// (get) Token: 0x0601F819 RID: 129049 RVA: 0x002ED56C File Offset: 0x002EB76C
		// (set) Token: 0x0601F81A RID: 129050 RVA: 0x002ED580 File Offset: 0x002EB780
		public unsafe FVector worldNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_worldNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_worldNormal) = value;
			}
		}

		// Token: 0x17007C45 RID: 31813
		// (get) Token: 0x0601F81B RID: 129051 RVA: 0x002ED595 File Offset: 0x002EB795
		// (set) Token: 0x0601F81C RID: 129052 RVA: 0x002ED5A5 File Offset: 0x002EB7A5
		public unsafe int faceIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_faceIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_faceIndex) = value;
			}
		}

		// Token: 0x17007C46 RID: 31814
		// (get) Token: 0x0601F81D RID: 129053 RVA: 0x002ED5B6 File Offset: 0x002EB7B6
		// (set) Token: 0x0601F81E RID: 129054 RVA: 0x002ED5C6 File Offset: 0x002EB7C6
		public unsafe byte elementIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_elementIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_elementIndex) = value;
			}
		}

		// Token: 0x17007C47 RID: 31815
		// (get) Token: 0x0601F81F RID: 129055 RVA: 0x002ED5D7 File Offset: 0x002EB7D7
		// (set) Token: 0x0601F820 RID: 129056 RVA: 0x002ED5E7 File Offset: 0x002EB7E7
		public unsafe int Item
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_Item);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_Item) = value;
			}
		}

		// Token: 0x17007C48 RID: 31816
		// (get) Token: 0x0601F821 RID: 129057 RVA: 0x002ED5F8 File Offset: 0x002EB7F8
		// (set) Token: 0x0601F822 RID: 129058 RVA: 0x002ED60C File Offset: 0x002EB80C
		public unsafe FVector moveDelta_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_moveDelta_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_moveDelta_DEPRECATED) = value;
			}
		}

		// Token: 0x17007C49 RID: 31817
		// (get) Token: 0x0601F823 RID: 129059 RVA: 0x002ED621 File Offset: 0x002EB821
		// (set) Token: 0x0601F824 RID: 129060 RVA: 0x002ED635 File Offset: 0x002EB835
		public unsafe FVector cumulativeMoveDelta_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_cumulativeMoveDelta_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_cumulativeMoveDelta_DEPRECATED) = value;
			}
		}

		// Token: 0x17007C4A RID: 31818
		// (get) Token: 0x0601F825 RID: 129061 RVA: 0x002ED64A File Offset: 0x002EB84A
		// (set) Token: 0x0601F826 RID: 129062 RVA: 0x002ED65A File Offset: 0x002EB85A
		public unsafe float scrollAxisValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_scrollAxisValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_scrollAxisValue) = value;
			}
		}

		// Token: 0x17007C4B RID: 31819
		// (get) Token: 0x0601F827 RID: 129063 RVA: 0x002ED66B File Offset: 0x002EB86B
		// (set) Token: 0x0601F828 RID: 129064 RVA: 0x002ED67F File Offset: 0x002EB87F
		public unsafe FVector rayOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_rayOrigin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_rayOrigin) = value;
			}
		}

		// Token: 0x17007C4C RID: 31820
		// (get) Token: 0x0601F829 RID: 129065 RVA: 0x002ED694 File Offset: 0x002EB894
		// (set) Token: 0x0601F82A RID: 129066 RVA: 0x002ED6A8 File Offset: 0x002EB8A8
		public unsafe FVector rayDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_rayDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_rayDirection) = value;
			}
		}

		// Token: 0x17007C4D RID: 31821
		// (get) Token: 0x0601F82B RID: 129067 RVA: 0x002ED6BD File Offset: 0x002EB8BD
		// (set) Token: 0x0601F82C RID: 129068 RVA: 0x002ED6D1 File Offset: 0x002EB8D1
		public unsafe ULGUIBaseRaycaster raycaster
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUIBaseRaycaster>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIPointerEventData.__PropertyOffset_raycaster);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIPointerEventData.__PropertyOffset_raycaster, value);
			}
		}

		// Token: 0x17007C4E RID: 31822
		// (get) Token: 0x0601F82D RID: 129069 RVA: 0x002ED6E6 File Offset: 0x002EB8E6
		// (set) Token: 0x0601F82E RID: 129070 RVA: 0x002ED6F6 File Offset: 0x002EB8F6
		public unsafe EMouseButtonType mouseButtonType
		{
			get
			{
				return (EMouseButtonType)(*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_mouseButtonType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_mouseButtonType) = (byte)value;
			}
		}

		// Token: 0x17007C4F RID: 31823
		// (get) Token: 0x0601F82F RID: 129071 RVA: 0x002ED707 File Offset: 0x002EB907
		// (set) Token: 0x0601F830 RID: 129072 RVA: 0x002ED71B File Offset: 0x002EB91B
		public unsafe USceneComponent pressComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIPointerEventData.__PropertyOffset_pressComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIPointerEventData.__PropertyOffset_pressComponent, value);
			}
		}

		// Token: 0x17007C50 RID: 31824
		// (get) Token: 0x0601F831 RID: 129073 RVA: 0x002ED730 File Offset: 0x002EB930
		// (set) Token: 0x0601F832 RID: 129074 RVA: 0x002ED744 File Offset: 0x002EB944
		public unsafe FVector pressWorldPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_pressWorldPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_pressWorldPoint) = value;
			}
		}

		// Token: 0x17007C51 RID: 31825
		// (get) Token: 0x0601F833 RID: 129075 RVA: 0x002ED759 File Offset: 0x002EB959
		// (set) Token: 0x0601F834 RID: 129076 RVA: 0x002ED76D File Offset: 0x002EB96D
		public unsafe FVector pressWorldNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_pressWorldNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_pressWorldNormal) = value;
			}
		}

		// Token: 0x17007C52 RID: 31826
		// (get) Token: 0x0601F835 RID: 129077 RVA: 0x002ED782 File Offset: 0x002EB982
		// (set) Token: 0x0601F836 RID: 129078 RVA: 0x002ED792 File Offset: 0x002EB992
		public unsafe float pressDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_pressDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_pressDistance) = value;
			}
		}

		// Token: 0x17007C53 RID: 31827
		// (get) Token: 0x0601F837 RID: 129079 RVA: 0x002ED7A3 File Offset: 0x002EB9A3
		// (set) Token: 0x0601F838 RID: 129080 RVA: 0x002ED7B7 File Offset: 0x002EB9B7
		public unsafe FVector pressRayOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_pressRayOrigin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_pressRayOrigin) = value;
			}
		}

		// Token: 0x17007C54 RID: 31828
		// (get) Token: 0x0601F839 RID: 129081 RVA: 0x002ED7CC File Offset: 0x002EB9CC
		// (set) Token: 0x0601F83A RID: 129082 RVA: 0x002ED7E0 File Offset: 0x002EB9E0
		public unsafe FVector pressRayDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_pressRayDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_pressRayDirection) = value;
			}
		}

		// Token: 0x17007C55 RID: 31829
		// (get) Token: 0x0601F83B RID: 129083 RVA: 0x002ED7F5 File Offset: 0x002EB9F5
		// (set) Token: 0x0601F83C RID: 129084 RVA: 0x002ED809 File Offset: 0x002EBA09
		public unsafe FTransform pressWorldToLocalTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_pressWorldToLocalTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_pressWorldToLocalTransform) = value;
			}
		}

		// Token: 0x17007C56 RID: 31830
		// (get) Token: 0x0601F83D RID: 129085 RVA: 0x002ED81E File Offset: 0x002EBA1E
		// (set) Token: 0x0601F83E RID: 129086 RVA: 0x002ED832 File Offset: 0x002EBA32
		public unsafe ULGUIBaseRaycaster pressRaycaster
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUIBaseRaycaster>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIPointerEventData.__PropertyOffset_pressRaycaster);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIPointerEventData.__PropertyOffset_pressRaycaster, value);
			}
		}

		// Token: 0x17007C57 RID: 31831
		// (get) Token: 0x0601F83F RID: 129087 RVA: 0x002ED847 File Offset: 0x002EBA47
		// (set) Token: 0x0601F840 RID: 129088 RVA: 0x002ED857 File Offset: 0x002EBA57
		public unsafe float clickTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_clickTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_clickTime) = value;
			}
		}

		// Token: 0x17007C58 RID: 31832
		// (get) Token: 0x0601F841 RID: 129089 RVA: 0x002ED868 File Offset: 0x002EBA68
		// (set) Token: 0x0601F842 RID: 129090 RVA: 0x002ED878 File Offset: 0x002EBA78
		public unsafe float pressTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_pressTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_pressTime) = value;
			}
		}

		// Token: 0x17007C59 RID: 31833
		// (get) Token: 0x0601F843 RID: 129091 RVA: 0x002ED889 File Offset: 0x002EBA89
		// (set) Token: 0x0601F844 RID: 129092 RVA: 0x002ED89D File Offset: 0x002EBA9D
		public unsafe FVector2D prevMousePos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_prevMousePos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_prevMousePos) = value;
			}
		}

		// Token: 0x17007C5A RID: 31834
		// (get) Token: 0x0601F845 RID: 129093 RVA: 0x002ED8B2 File Offset: 0x002EBAB2
		// (set) Token: 0x0601F846 RID: 129094 RVA: 0x002ED8C2 File Offset: 0x002EBAC2
		public unsafe bool isDragging
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_isDragging) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_isDragging) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007C5B RID: 31835
		// (get) Token: 0x0601F847 RID: 129095 RVA: 0x002ED8D3 File Offset: 0x002EBAD3
		// (set) Token: 0x0601F848 RID: 129096 RVA: 0x002ED8E7 File Offset: 0x002EBAE7
		public unsafe USceneComponent dragComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIPointerEventData.__PropertyOffset_dragComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIPointerEventData.__PropertyOffset_dragComponent, value);
			}
		}

		// Token: 0x17007C5C RID: 31836
		// (get) Token: 0x0601F849 RID: 129097 RVA: 0x002ED8FC File Offset: 0x002EBAFC
		// (set) Token: 0x0601F84A RID: 129098 RVA: 0x002ED910 File Offset: 0x002EBB10
		public unsafe FVector dragRayOrigin_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_dragRayOrigin_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_dragRayOrigin_DEPRECATED) = value;
			}
		}

		// Token: 0x17007C5D RID: 31837
		// (get) Token: 0x0601F84B RID: 129099 RVA: 0x002ED925 File Offset: 0x002EBB25
		// (set) Token: 0x0601F84C RID: 129100 RVA: 0x002ED939 File Offset: 0x002EBB39
		public unsafe FVector dragRayDirection_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_dragRayDirection_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_dragRayDirection_DEPRECATED) = value;
			}
		}

		// Token: 0x17007C5E RID: 31838
		// (get) Token: 0x0601F84D RID: 129101 RVA: 0x002ED94E File Offset: 0x002EBB4E
		// (set) Token: 0x0601F84E RID: 129102 RVA: 0x002ED95E File Offset: 0x002EBB5E
		public unsafe bool nowIsTriggerPressed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_nowIsTriggerPressed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_nowIsTriggerPressed) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007C5F RID: 31839
		// (get) Token: 0x0601F84F RID: 129103 RVA: 0x002ED96F File Offset: 0x002EBB6F
		// (set) Token: 0x0601F850 RID: 129104 RVA: 0x002ED97F File Offset: 0x002EBB7F
		public unsafe bool dragDropTriggered
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_dragDropTriggered) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPointerEventData.__PropertyOffset_dragDropTriggered) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F851 RID: 129105 RVA: 0x002ED990 File Offset: 0x002EBB90
		public FVector GetWorldPointSpherical()
		{
			return ULGUIPointerEventData.__GetWorldPointSpherical_Internal(base.NativePtr);
		}

		// Token: 0x0601F852 RID: 129106 RVA: 0x002ED99D File Offset: 0x002EBB9D
		public FVector GetWorldPointInPlane()
		{
			return ULGUIPointerEventData.__GetWorldPointInPlane_Internal(base.NativePtr);
		}

		// Token: 0x0601F853 RID: 129107 RVA: 0x002ED9AA File Offset: 0x002EBBAA
		public FVector GetLocalPointInPlane()
		{
			return ULGUIPointerEventData.__GetLocalPointInPlane_Internal(base.NativePtr);
		}

		// Token: 0x0601F854 RID: 129108 RVA: 0x002ED9B7 File Offset: 0x002EBBB7
		public FVector GetDragRayOrigin()
		{
			return ULGUIPointerEventData.__GetDragRayOrigin_Internal(base.NativePtr);
		}

		// Token: 0x0601F855 RID: 129109 RVA: 0x002ED9C4 File Offset: 0x002EBBC4
		public FVector GetDragRayDirection()
		{
			return ULGUIPointerEventData.__GetDragRayDirection_Internal(base.NativePtr);
		}

		// Token: 0x0601F856 RID: 129110 RVA: 0x002ED9D1 File Offset: 0x002EBBD1
		public FVector GetCumulativeMoveDelta()
		{
			return ULGUIPointerEventData.__GetCumulativeMoveDelta_Internal(base.NativePtr);
		}

		// Token: 0x0601F857 RID: 129111
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetWorldPointSpherical_Internal(IntPtr @this);

		// Token: 0x0601F858 RID: 129112
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetWorldPointInPlane_Internal(IntPtr @this);

		// Token: 0x0601F859 RID: 129113
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLocalPointInPlane_Internal(IntPtr @this);

		// Token: 0x0601F85A RID: 129114
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetDragRayOrigin_Internal(IntPtr @this);

		// Token: 0x0601F85B RID: 129115
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetDragRayDirection_Internal(IntPtr @this);

		// Token: 0x0601F85C RID: 129116
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetCumulativeMoveDelta_Internal(IntPtr @this);

		// Token: 0x0601F85D RID: 129117 RVA: 0x002ED9DE File Offset: 0x002EBBDE
		static ULGUIPointerEventData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIPointerEventData");
		}

		// Token: 0x0601F85E RID: 129118 RVA: 0x002ED9EC File Offset: 0x002EBBEC
		protected ULGUIPointerEventData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011022 RID: 69666
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIPointerEventData";

		// Token: 0x04011023 RID: 69667
		private static IntPtr _ClassPtr;

		// Token: 0x04011024 RID: 69668
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011025 RID: 69669
		internal static int __PropertyOffset_inputType;

		// Token: 0x04011026 RID: 69670
		internal static int __PropertyOffset_pointerID;

		// Token: 0x04011027 RID: 69671
		internal static int __PropertyOffset_pointerPosition;

		// Token: 0x04011028 RID: 69672
		internal static int __PropertyOffset_currentComponent_DEPRECATED;

		// Token: 0x04011029 RID: 69673
		internal static int __PropertyOffset_enterComponent;

		// Token: 0x0401102A RID: 69674
		internal static int __PropertyOffset_enterComponentStack;

		// Token: 0x0401102B RID: 69675
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USceneComponent> _enterComponentStack;

		// Token: 0x0401102C RID: 69676
		internal static int __PropertyOffset_hoverComponentArray;

		// Token: 0x0401102D RID: 69677
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USceneComponent> _hoverComponentArray;

		// Token: 0x0401102E RID: 69678
		internal static int __PropertyOffset_worldPoint;

		// Token: 0x0401102F RID: 69679
		internal static int __PropertyOffset_worldNormal;

		// Token: 0x04011030 RID: 69680
		internal static int __PropertyOffset_faceIndex;

		// Token: 0x04011031 RID: 69681
		internal static int __PropertyOffset_elementIndex;

		// Token: 0x04011032 RID: 69682
		internal static int __PropertyOffset_Item;

		// Token: 0x04011033 RID: 69683
		internal static int __PropertyOffset_moveDelta_DEPRECATED;

		// Token: 0x04011034 RID: 69684
		internal static int __PropertyOffset_cumulativeMoveDelta_DEPRECATED;

		// Token: 0x04011035 RID: 69685
		internal static int __PropertyOffset_scrollAxisValue;

		// Token: 0x04011036 RID: 69686
		internal static int __PropertyOffset_rayOrigin;

		// Token: 0x04011037 RID: 69687
		internal static int __PropertyOffset_rayDirection;

		// Token: 0x04011038 RID: 69688
		internal static int __PropertyOffset_raycaster;

		// Token: 0x04011039 RID: 69689
		internal static int __PropertyOffset_mouseButtonType;

		// Token: 0x0401103A RID: 69690
		internal static int __PropertyOffset_pressComponent;

		// Token: 0x0401103B RID: 69691
		internal static int __PropertyOffset_pressWorldPoint;

		// Token: 0x0401103C RID: 69692
		internal static int __PropertyOffset_pressWorldNormal;

		// Token: 0x0401103D RID: 69693
		internal static int __PropertyOffset_pressDistance;

		// Token: 0x0401103E RID: 69694
		internal static int __PropertyOffset_pressRayOrigin;

		// Token: 0x0401103F RID: 69695
		internal static int __PropertyOffset_pressRayDirection;

		// Token: 0x04011040 RID: 69696
		internal static int __PropertyOffset_pressWorldToLocalTransform;

		// Token: 0x04011041 RID: 69697
		internal static int __PropertyOffset_pressRaycaster;

		// Token: 0x04011042 RID: 69698
		internal static int __PropertyOffset_clickTime;

		// Token: 0x04011043 RID: 69699
		internal static int __PropertyOffset_pressTime;

		// Token: 0x04011044 RID: 69700
		internal static int __PropertyOffset_prevMousePos;

		// Token: 0x04011045 RID: 69701
		internal static int __PropertyOffset_isDragging;

		// Token: 0x04011046 RID: 69702
		internal static int __PropertyOffset_dragComponent;

		// Token: 0x04011047 RID: 69703
		internal static int __PropertyOffset_dragRayOrigin_DEPRECATED;

		// Token: 0x04011048 RID: 69704
		internal static int __PropertyOffset_dragRayDirection_DEPRECATED;

		// Token: 0x04011049 RID: 69705
		internal static int __PropertyOffset_nowIsTriggerPressed;

		// Token: 0x0401104A RID: 69706
		internal static int __PropertyOffset_dragDropTriggered;
	}
}

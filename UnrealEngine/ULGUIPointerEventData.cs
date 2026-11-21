using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006B2 RID: 1714
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIPointerEventData")]
	[UnrealStructLayout(512, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 512)]
	public class ULGUIPointerEventData : ULGUIBaseEventData, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060092FA RID: 37626 RVA: 0x000DD64E File Offset: 0x000DB84E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIPointerEventData._ClassPtr;
		}

		// Token: 0x060092FB RID: 37627 RVA: 0x000DD65C File Offset: 0x000DB85C
		public ULGUIPointerEventData() : this(BuiltinUtils.AllocNativeUObject(ULGUIPointerEventData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060092FC RID: 37628 RVA: 0x000DD684 File Offset: 0x000DB884
		[NullableContext(1)]
		public ULGUIPointerEventData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIPointerEventData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B66 RID: 7014
		// (get) Token: 0x060092FD RID: 37629 RVA: 0x000DD6B7 File Offset: 0x000DB8B7
		// (set) Token: 0x060092FE RID: 37630 RVA: 0x000DD6C7 File Offset: 0x000DB8C7
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

		// Token: 0x17001B67 RID: 7015
		// (get) Token: 0x060092FF RID: 37631 RVA: 0x000DD6D8 File Offset: 0x000DB8D8
		// (set) Token: 0x06009300 RID: 37632 RVA: 0x000DD6E8 File Offset: 0x000DB8E8
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

		// Token: 0x17001B68 RID: 7016
		// (get) Token: 0x06009301 RID: 37633 RVA: 0x000DD6F9 File Offset: 0x000DB8F9
		// (set) Token: 0x06009302 RID: 37634 RVA: 0x000DD70D File Offset: 0x000DB90D
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

		// Token: 0x17001B69 RID: 7017
		// (get) Token: 0x06009303 RID: 37635 RVA: 0x000DD722 File Offset: 0x000DB922
		// (set) Token: 0x06009304 RID: 37636 RVA: 0x000DD736 File Offset: 0x000DB936
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

		// Token: 0x17001B6A RID: 7018
		// (get) Token: 0x06009305 RID: 37637 RVA: 0x000DD74B File Offset: 0x000DB94B
		// (set) Token: 0x06009306 RID: 37638 RVA: 0x000DD75F File Offset: 0x000DB95F
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

		// Token: 0x17001B6B RID: 7019
		// (get) Token: 0x06009307 RID: 37639 RVA: 0x000DD774 File Offset: 0x000DB974
		// (set) Token: 0x06009308 RID: 37640 RVA: 0x000DD7AD File Offset: 0x000DB9AD
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

		// Token: 0x17001B6C RID: 7020
		// (get) Token: 0x06009309 RID: 37641 RVA: 0x000DD7BC File Offset: 0x000DB9BC
		// (set) Token: 0x0600930A RID: 37642 RVA: 0x000DD7F5 File Offset: 0x000DB9F5
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

		// Token: 0x17001B6D RID: 7021
		// (get) Token: 0x0600930B RID: 37643 RVA: 0x000DD803 File Offset: 0x000DBA03
		// (set) Token: 0x0600930C RID: 37644 RVA: 0x000DD817 File Offset: 0x000DBA17
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

		// Token: 0x17001B6E RID: 7022
		// (get) Token: 0x0600930D RID: 37645 RVA: 0x000DD82C File Offset: 0x000DBA2C
		// (set) Token: 0x0600930E RID: 37646 RVA: 0x000DD840 File Offset: 0x000DBA40
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

		// Token: 0x17001B6F RID: 7023
		// (get) Token: 0x0600930F RID: 37647 RVA: 0x000DD855 File Offset: 0x000DBA55
		// (set) Token: 0x06009310 RID: 37648 RVA: 0x000DD865 File Offset: 0x000DBA65
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

		// Token: 0x17001B70 RID: 7024
		// (get) Token: 0x06009311 RID: 37649 RVA: 0x000DD876 File Offset: 0x000DBA76
		// (set) Token: 0x06009312 RID: 37650 RVA: 0x000DD886 File Offset: 0x000DBA86
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

		// Token: 0x17001B71 RID: 7025
		// (get) Token: 0x06009313 RID: 37651 RVA: 0x000DD897 File Offset: 0x000DBA97
		// (set) Token: 0x06009314 RID: 37652 RVA: 0x000DD8A7 File Offset: 0x000DBAA7
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

		// Token: 0x17001B72 RID: 7026
		// (get) Token: 0x06009315 RID: 37653 RVA: 0x000DD8B8 File Offset: 0x000DBAB8
		// (set) Token: 0x06009316 RID: 37654 RVA: 0x000DD8CC File Offset: 0x000DBACC
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

		// Token: 0x17001B73 RID: 7027
		// (get) Token: 0x06009317 RID: 37655 RVA: 0x000DD8E1 File Offset: 0x000DBAE1
		// (set) Token: 0x06009318 RID: 37656 RVA: 0x000DD8F5 File Offset: 0x000DBAF5
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

		// Token: 0x17001B74 RID: 7028
		// (get) Token: 0x06009319 RID: 37657 RVA: 0x000DD90A File Offset: 0x000DBB0A
		// (set) Token: 0x0600931A RID: 37658 RVA: 0x000DD91A File Offset: 0x000DBB1A
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

		// Token: 0x17001B75 RID: 7029
		// (get) Token: 0x0600931B RID: 37659 RVA: 0x000DD92B File Offset: 0x000DBB2B
		// (set) Token: 0x0600931C RID: 37660 RVA: 0x000DD93F File Offset: 0x000DBB3F
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

		// Token: 0x17001B76 RID: 7030
		// (get) Token: 0x0600931D RID: 37661 RVA: 0x000DD954 File Offset: 0x000DBB54
		// (set) Token: 0x0600931E RID: 37662 RVA: 0x000DD968 File Offset: 0x000DBB68
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

		// Token: 0x17001B77 RID: 7031
		// (get) Token: 0x0600931F RID: 37663 RVA: 0x000DD97D File Offset: 0x000DBB7D
		// (set) Token: 0x06009320 RID: 37664 RVA: 0x000DD991 File Offset: 0x000DBB91
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

		// Token: 0x17001B78 RID: 7032
		// (get) Token: 0x06009321 RID: 37665 RVA: 0x000DD9A6 File Offset: 0x000DBBA6
		// (set) Token: 0x06009322 RID: 37666 RVA: 0x000DD9B6 File Offset: 0x000DBBB6
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

		// Token: 0x17001B79 RID: 7033
		// (get) Token: 0x06009323 RID: 37667 RVA: 0x000DD9C7 File Offset: 0x000DBBC7
		// (set) Token: 0x06009324 RID: 37668 RVA: 0x000DD9DB File Offset: 0x000DBBDB
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

		// Token: 0x17001B7A RID: 7034
		// (get) Token: 0x06009325 RID: 37669 RVA: 0x000DD9F0 File Offset: 0x000DBBF0
		// (set) Token: 0x06009326 RID: 37670 RVA: 0x000DDA04 File Offset: 0x000DBC04
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

		// Token: 0x17001B7B RID: 7035
		// (get) Token: 0x06009327 RID: 37671 RVA: 0x000DDA19 File Offset: 0x000DBC19
		// (set) Token: 0x06009328 RID: 37672 RVA: 0x000DDA2D File Offset: 0x000DBC2D
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

		// Token: 0x17001B7C RID: 7036
		// (get) Token: 0x06009329 RID: 37673 RVA: 0x000DDA42 File Offset: 0x000DBC42
		// (set) Token: 0x0600932A RID: 37674 RVA: 0x000DDA52 File Offset: 0x000DBC52
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

		// Token: 0x17001B7D RID: 7037
		// (get) Token: 0x0600932B RID: 37675 RVA: 0x000DDA63 File Offset: 0x000DBC63
		// (set) Token: 0x0600932C RID: 37676 RVA: 0x000DDA77 File Offset: 0x000DBC77
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

		// Token: 0x17001B7E RID: 7038
		// (get) Token: 0x0600932D RID: 37677 RVA: 0x000DDA8C File Offset: 0x000DBC8C
		// (set) Token: 0x0600932E RID: 37678 RVA: 0x000DDAA0 File Offset: 0x000DBCA0
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

		// Token: 0x17001B7F RID: 7039
		// (get) Token: 0x0600932F RID: 37679 RVA: 0x000DDAB5 File Offset: 0x000DBCB5
		// (set) Token: 0x06009330 RID: 37680 RVA: 0x000DDAC9 File Offset: 0x000DBCC9
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

		// Token: 0x17001B80 RID: 7040
		// (get) Token: 0x06009331 RID: 37681 RVA: 0x000DDADE File Offset: 0x000DBCDE
		// (set) Token: 0x06009332 RID: 37682 RVA: 0x000DDAF2 File Offset: 0x000DBCF2
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

		// Token: 0x17001B81 RID: 7041
		// (get) Token: 0x06009333 RID: 37683 RVA: 0x000DDB07 File Offset: 0x000DBD07
		// (set) Token: 0x06009334 RID: 37684 RVA: 0x000DDB17 File Offset: 0x000DBD17
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

		// Token: 0x17001B82 RID: 7042
		// (get) Token: 0x06009335 RID: 37685 RVA: 0x000DDB28 File Offset: 0x000DBD28
		// (set) Token: 0x06009336 RID: 37686 RVA: 0x000DDB38 File Offset: 0x000DBD38
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

		// Token: 0x17001B83 RID: 7043
		// (get) Token: 0x06009337 RID: 37687 RVA: 0x000DDB49 File Offset: 0x000DBD49
		// (set) Token: 0x06009338 RID: 37688 RVA: 0x000DDB5D File Offset: 0x000DBD5D
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

		// Token: 0x17001B84 RID: 7044
		// (get) Token: 0x06009339 RID: 37689 RVA: 0x000DDB72 File Offset: 0x000DBD72
		// (set) Token: 0x0600933A RID: 37690 RVA: 0x000DDB82 File Offset: 0x000DBD82
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

		// Token: 0x17001B85 RID: 7045
		// (get) Token: 0x0600933B RID: 37691 RVA: 0x000DDB93 File Offset: 0x000DBD93
		// (set) Token: 0x0600933C RID: 37692 RVA: 0x000DDBA7 File Offset: 0x000DBDA7
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

		// Token: 0x17001B86 RID: 7046
		// (get) Token: 0x0600933D RID: 37693 RVA: 0x000DDBBC File Offset: 0x000DBDBC
		// (set) Token: 0x0600933E RID: 37694 RVA: 0x000DDBD0 File Offset: 0x000DBDD0
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

		// Token: 0x17001B87 RID: 7047
		// (get) Token: 0x0600933F RID: 37695 RVA: 0x000DDBE5 File Offset: 0x000DBDE5
		// (set) Token: 0x06009340 RID: 37696 RVA: 0x000DDBF9 File Offset: 0x000DBDF9
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

		// Token: 0x17001B88 RID: 7048
		// (get) Token: 0x06009341 RID: 37697 RVA: 0x000DDC0E File Offset: 0x000DBE0E
		// (set) Token: 0x06009342 RID: 37698 RVA: 0x000DDC1E File Offset: 0x000DBE1E
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

		// Token: 0x17001B89 RID: 7049
		// (get) Token: 0x06009343 RID: 37699 RVA: 0x000DDC2F File Offset: 0x000DBE2F
		// (set) Token: 0x06009344 RID: 37700 RVA: 0x000DDC3F File Offset: 0x000DBE3F
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

		// Token: 0x06009345 RID: 37701 RVA: 0x000DDC50 File Offset: 0x000DBE50
		public FVector GetWorldPointSpherical()
		{
			return ULGUIPointerEventData.__GetWorldPointSpherical_Internal(base.NativePtr);
		}

		// Token: 0x06009346 RID: 37702 RVA: 0x000DDC5D File Offset: 0x000DBE5D
		public FVector GetWorldPointInPlane()
		{
			return ULGUIPointerEventData.__GetWorldPointInPlane_Internal(base.NativePtr);
		}

		// Token: 0x06009347 RID: 37703 RVA: 0x000DDC6A File Offset: 0x000DBE6A
		public FVector GetLocalPointInPlane()
		{
			return ULGUIPointerEventData.__GetLocalPointInPlane_Internal(base.NativePtr);
		}

		// Token: 0x06009348 RID: 37704 RVA: 0x000DDC77 File Offset: 0x000DBE77
		public FVector GetDragRayOrigin()
		{
			return ULGUIPointerEventData.__GetDragRayOrigin_Internal(base.NativePtr);
		}

		// Token: 0x06009349 RID: 37705 RVA: 0x000DDC84 File Offset: 0x000DBE84
		public FVector GetDragRayDirection()
		{
			return ULGUIPointerEventData.__GetDragRayDirection_Internal(base.NativePtr);
		}

		// Token: 0x0600934A RID: 37706 RVA: 0x000DDC91 File Offset: 0x000DBE91
		public FVector GetCumulativeMoveDelta()
		{
			return ULGUIPointerEventData.__GetCumulativeMoveDelta_Internal(base.NativePtr);
		}

		// Token: 0x0600934B RID: 37707
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetWorldPointSpherical_Internal(IntPtr @this);

		// Token: 0x0600934C RID: 37708
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetWorldPointInPlane_Internal(IntPtr @this);

		// Token: 0x0600934D RID: 37709
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLocalPointInPlane_Internal(IntPtr @this);

		// Token: 0x0600934E RID: 37710
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetDragRayOrigin_Internal(IntPtr @this);

		// Token: 0x0600934F RID: 37711
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetDragRayDirection_Internal(IntPtr @this);

		// Token: 0x06009350 RID: 37712
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetCumulativeMoveDelta_Internal(IntPtr @this);

		// Token: 0x06009351 RID: 37713 RVA: 0x000DDC9E File Offset: 0x000DBE9E
		static ULGUIPointerEventData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIPointerEventData");
		}

		// Token: 0x06009352 RID: 37714 RVA: 0x000DDCAC File Offset: 0x000DBEAC
		protected ULGUIPointerEventData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004011 RID: 16401
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIPointerEventData";

		// Token: 0x04004012 RID: 16402
		private static IntPtr _ClassPtr;

		// Token: 0x04004013 RID: 16403
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004014 RID: 16404
		internal static int __PropertyOffset_inputType;

		// Token: 0x04004015 RID: 16405
		internal static int __PropertyOffset_pointerID;

		// Token: 0x04004016 RID: 16406
		internal static int __PropertyOffset_pointerPosition;

		// Token: 0x04004017 RID: 16407
		internal static int __PropertyOffset_currentComponent_DEPRECATED;

		// Token: 0x04004018 RID: 16408
		internal static int __PropertyOffset_enterComponent;

		// Token: 0x04004019 RID: 16409
		internal static int __PropertyOffset_enterComponentStack;

		// Token: 0x0400401A RID: 16410
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USceneComponent> _enterComponentStack;

		// Token: 0x0400401B RID: 16411
		internal static int __PropertyOffset_hoverComponentArray;

		// Token: 0x0400401C RID: 16412
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USceneComponent> _hoverComponentArray;

		// Token: 0x0400401D RID: 16413
		internal static int __PropertyOffset_worldPoint;

		// Token: 0x0400401E RID: 16414
		internal static int __PropertyOffset_worldNormal;

		// Token: 0x0400401F RID: 16415
		internal static int __PropertyOffset_faceIndex;

		// Token: 0x04004020 RID: 16416
		internal static int __PropertyOffset_elementIndex;

		// Token: 0x04004021 RID: 16417
		internal static int __PropertyOffset_Item;

		// Token: 0x04004022 RID: 16418
		internal static int __PropertyOffset_moveDelta_DEPRECATED;

		// Token: 0x04004023 RID: 16419
		internal static int __PropertyOffset_cumulativeMoveDelta_DEPRECATED;

		// Token: 0x04004024 RID: 16420
		internal static int __PropertyOffset_scrollAxisValue;

		// Token: 0x04004025 RID: 16421
		internal static int __PropertyOffset_rayOrigin;

		// Token: 0x04004026 RID: 16422
		internal static int __PropertyOffset_rayDirection;

		// Token: 0x04004027 RID: 16423
		internal static int __PropertyOffset_raycaster;

		// Token: 0x04004028 RID: 16424
		internal static int __PropertyOffset_mouseButtonType;

		// Token: 0x04004029 RID: 16425
		internal static int __PropertyOffset_pressComponent;

		// Token: 0x0400402A RID: 16426
		internal static int __PropertyOffset_pressWorldPoint;

		// Token: 0x0400402B RID: 16427
		internal static int __PropertyOffset_pressWorldNormal;

		// Token: 0x0400402C RID: 16428
		internal static int __PropertyOffset_pressDistance;

		// Token: 0x0400402D RID: 16429
		internal static int __PropertyOffset_pressRayOrigin;

		// Token: 0x0400402E RID: 16430
		internal static int __PropertyOffset_pressRayDirection;

		// Token: 0x0400402F RID: 16431
		internal static int __PropertyOffset_pressWorldToLocalTransform;

		// Token: 0x04004030 RID: 16432
		internal static int __PropertyOffset_pressRaycaster;

		// Token: 0x04004031 RID: 16433
		internal static int __PropertyOffset_clickTime;

		// Token: 0x04004032 RID: 16434
		internal static int __PropertyOffset_pressTime;

		// Token: 0x04004033 RID: 16435
		internal static int __PropertyOffset_prevMousePos;

		// Token: 0x04004034 RID: 16436
		internal static int __PropertyOffset_isDragging;

		// Token: 0x04004035 RID: 16437
		internal static int __PropertyOffset_dragComponent;

		// Token: 0x04004036 RID: 16438
		internal static int __PropertyOffset_dragRayOrigin_DEPRECATED;

		// Token: 0x04004037 RID: 16439
		internal static int __PropertyOffset_dragRayDirection_DEPRECATED;

		// Token: 0x04004038 RID: 16440
		internal static int __PropertyOffset_nowIsTriggerPressed;

		// Token: 0x04004039 RID: 16441
		internal static int __PropertyOffset_dragDropTriggered;
	}
}

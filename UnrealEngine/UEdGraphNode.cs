using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000A48 RID: 2632
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.EdGraphNode")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UEdGraphNode : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008ECE RID: 36558 RVA: 0x000CC321 File Offset: 0x000CA521
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEdGraphNode._ClassPtr;
		}

		// Token: 0x06008ECF RID: 36559 RVA: 0x000CC330 File Offset: 0x000CA530
		public UEdGraphNode() : this(BuiltinUtils.AllocNativeUObject(UEdGraphNode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008ED0 RID: 36560 RVA: 0x000CC358 File Offset: 0x000CA558
		public UEdGraphNode(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEdGraphNode.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170021A4 RID: 8612
		// (get) Token: 0x06008ED1 RID: 36561 RVA: 0x000CC38C File Offset: 0x000CA58C
		// (set) Token: 0x06008ED2 RID: 36562 RVA: 0x000CC3C5 File Offset: 0x000CA5C5
		public TArray<UEdGraphPin_Deprecated> DeprecatedPins
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UEdGraphPin_Deprecated> result;
				if ((result = this._DeprecatedPins) == null)
				{
					result = (this._DeprecatedPins = new TArray<UEdGraphPin_Deprecated>(base.NativePtr + (IntPtr)UEdGraphNode.__PropertyOffset_DeprecatedPins, this));
				}
				return result;
			}
			set
			{
				this.DeprecatedPins.CopyAssign(value);
			}
		}

		// Token: 0x170021A5 RID: 8613
		// (get) Token: 0x06008ED3 RID: 36563 RVA: 0x000CC3D3 File Offset: 0x000CA5D3
		// (set) Token: 0x06008ED4 RID: 36564 RVA: 0x000CC3E3 File Offset: 0x000CA5E3
		public unsafe int NodePosX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEdGraphNode.__PropertyOffset_NodePosX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEdGraphNode.__PropertyOffset_NodePosX) = value;
			}
		}

		// Token: 0x170021A6 RID: 8614
		// (get) Token: 0x06008ED5 RID: 36565 RVA: 0x000CC3F4 File Offset: 0x000CA5F4
		// (set) Token: 0x06008ED6 RID: 36566 RVA: 0x000CC404 File Offset: 0x000CA604
		public unsafe int NodePosY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEdGraphNode.__PropertyOffset_NodePosY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEdGraphNode.__PropertyOffset_NodePosY) = value;
			}
		}

		// Token: 0x170021A7 RID: 8615
		// (get) Token: 0x06008ED7 RID: 36567 RVA: 0x000CC415 File Offset: 0x000CA615
		// (set) Token: 0x06008ED8 RID: 36568 RVA: 0x000CC425 File Offset: 0x000CA625
		public unsafe int NodeWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEdGraphNode.__PropertyOffset_NodeWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEdGraphNode.__PropertyOffset_NodeWidth) = value;
			}
		}

		// Token: 0x170021A8 RID: 8616
		// (get) Token: 0x06008ED9 RID: 36569 RVA: 0x000CC436 File Offset: 0x000CA636
		// (set) Token: 0x06008EDA RID: 36570 RVA: 0x000CC446 File Offset: 0x000CA646
		public unsafe int NodeHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEdGraphNode.__PropertyOffset_NodeHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEdGraphNode.__PropertyOffset_NodeHeight) = value;
			}
		}

		// Token: 0x170021A9 RID: 8617
		// (get) Token: 0x06008EDB RID: 36571 RVA: 0x000CC457 File Offset: 0x000CA657
		// (set) Token: 0x06008EDC RID: 36572 RVA: 0x000CC46B File Offset: 0x000CA66B
		[Nullable(0)]
		public unsafe TEnumAsByte<ENodeAdvancedPins> AdvancedPinDisplay
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UEdGraphNode.__PropertyOffset_AdvancedPinDisplay);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UEdGraphNode.__PropertyOffset_AdvancedPinDisplay) = value;
			}
		}

		// Token: 0x170021AA RID: 8618
		// (get) Token: 0x06008EDD RID: 36573 RVA: 0x000CC480 File Offset: 0x000CA680
		// (set) Token: 0x06008EDE RID: 36574 RVA: 0x000CC490 File Offset: 0x000CA690
		public unsafe ENodeEnabledState EnabledState
		{
			get
			{
				return (ENodeEnabledState)(*(base.NativePtr + (IntPtr)UEdGraphNode.__PropertyOffset_EnabledState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEdGraphNode.__PropertyOffset_EnabledState) = (byte)value;
			}
		}

		// Token: 0x170021AB RID: 8619
		// (get) Token: 0x06008EDF RID: 36575 RVA: 0x000CC4A1 File Offset: 0x000CA6A1
		// (set) Token: 0x06008EE0 RID: 36576 RVA: 0x000CC4BA File Offset: 0x000CA6BA
		public unsafe bool bDisplayAsDisabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEdGraphNode.__PropertyOffset_bDisplayAsDisabled) & UEdGraphNode.__PropertyMask_bDisplayAsDisabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEdGraphNode.__PropertyOffset_bDisplayAsDisabled) = ((*(base.NativePtr + (IntPtr)UEdGraphNode.__PropertyOffset_bDisplayAsDisabled) & ~UEdGraphNode.__PropertyMask_bDisplayAsDisabled) | (value ? UEdGraphNode.__PropertyMask_bDisplayAsDisabled : 0));
			}
		}

		// Token: 0x170021AC RID: 8620
		// (get) Token: 0x06008EE1 RID: 36577 RVA: 0x000CC4EA File Offset: 0x000CA6EA
		// (set) Token: 0x06008EE2 RID: 36578 RVA: 0x000CC503 File Offset: 0x000CA703
		public unsafe bool bUserSetEnabledState
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEdGraphNode.__PropertyOffset_bUserSetEnabledState) & UEdGraphNode.__PropertyMask_bUserSetEnabledState) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEdGraphNode.__PropertyOffset_bUserSetEnabledState) = ((*(base.NativePtr + (IntPtr)UEdGraphNode.__PropertyOffset_bUserSetEnabledState) & ~UEdGraphNode.__PropertyMask_bUserSetEnabledState) | (value ? UEdGraphNode.__PropertyMask_bUserSetEnabledState : 0));
			}
		}

		// Token: 0x170021AD RID: 8621
		// (get) Token: 0x06008EE3 RID: 36579 RVA: 0x000CC533 File Offset: 0x000CA733
		// (set) Token: 0x06008EE4 RID: 36580 RVA: 0x000CC54C File Offset: 0x000CA74C
		public unsafe bool bIsNodeEnabled_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEdGraphNode.__PropertyOffset_bIsNodeEnabled_DEPRECATED) & UEdGraphNode.__PropertyMask_bIsNodeEnabled_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEdGraphNode.__PropertyOffset_bIsNodeEnabled_DEPRECATED) = ((*(base.NativePtr + (IntPtr)UEdGraphNode.__PropertyOffset_bIsNodeEnabled_DEPRECATED) & ~UEdGraphNode.__PropertyMask_bIsNodeEnabled_DEPRECATED) | (value ? UEdGraphNode.__PropertyMask_bIsNodeEnabled_DEPRECATED : 0));
			}
		}

		// Token: 0x170021AE RID: 8622
		// (get) Token: 0x06008EE5 RID: 36581 RVA: 0x000CC57C File Offset: 0x000CA77C
		// (set) Token: 0x06008EE6 RID: 36582 RVA: 0x000CC595 File Offset: 0x000CA795
		public unsafe bool bHasCompilerMessage
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEdGraphNode.__PropertyOffset_bHasCompilerMessage) & UEdGraphNode.__PropertyMask_bHasCompilerMessage) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEdGraphNode.__PropertyOffset_bHasCompilerMessage) = ((*(base.NativePtr + (IntPtr)UEdGraphNode.__PropertyOffset_bHasCompilerMessage) & ~UEdGraphNode.__PropertyMask_bHasCompilerMessage) | (value ? UEdGraphNode.__PropertyMask_bHasCompilerMessage : 0));
			}
		}

		// Token: 0x170021AF RID: 8623
		// (get) Token: 0x06008EE7 RID: 36583 RVA: 0x000CC5C5 File Offset: 0x000CA7C5
		// (set) Token: 0x06008EE8 RID: 36584 RVA: 0x000CC5D9 File Offset: 0x000CA7D9
		public unsafe string NodeComment
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEdGraphNode.__PropertyOffset_NodeComment)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEdGraphNode.__PropertyOffset_NodeComment)), value);
			}
		}

		// Token: 0x170021B0 RID: 8624
		// (get) Token: 0x06008EE9 RID: 36585 RVA: 0x000CC5EE File Offset: 0x000CA7EE
		// (set) Token: 0x06008EEA RID: 36586 RVA: 0x000CC5FE File Offset: 0x000CA7FE
		public unsafe int ErrorType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEdGraphNode.__PropertyOffset_ErrorType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEdGraphNode.__PropertyOffset_ErrorType) = value;
			}
		}

		// Token: 0x170021B1 RID: 8625
		// (get) Token: 0x06008EEB RID: 36587 RVA: 0x000CC60F File Offset: 0x000CA80F
		// (set) Token: 0x06008EEC RID: 36588 RVA: 0x000CC623 File Offset: 0x000CA823
		public unsafe string ErrorMsg
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEdGraphNode.__PropertyOffset_ErrorMsg)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEdGraphNode.__PropertyOffset_ErrorMsg)), value);
			}
		}

		// Token: 0x170021B2 RID: 8626
		// (get) Token: 0x06008EED RID: 36589 RVA: 0x000CC638 File Offset: 0x000CA838
		// (set) Token: 0x06008EEE RID: 36590 RVA: 0x000CC64C File Offset: 0x000CA84C
		public unsafe FGuid NodeGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEdGraphNode.__PropertyOffset_NodeGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEdGraphNode.__PropertyOffset_NodeGuid) = value;
			}
		}

		// Token: 0x06008EEF RID: 36591 RVA: 0x000CC661 File Offset: 0x000CA861
		static UEdGraphNode()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.EdGraphNode");
		}

		// Token: 0x06008EF0 RID: 36592 RVA: 0x000CC66F File Offset: 0x000CA86F
		protected UEdGraphNode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004676 RID: 18038
		public new const string __ObjectPath = "/Script/Engine.EdGraphNode";

		// Token: 0x04004677 RID: 18039
		private static IntPtr _ClassPtr;

		// Token: 0x04004678 RID: 18040
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004679 RID: 18041
		internal static int __PropertyOffset_DeprecatedPins;

		// Token: 0x0400467A RID: 18042
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UEdGraphPin_Deprecated> _DeprecatedPins;

		// Token: 0x0400467B RID: 18043
		internal static int __PropertyOffset_NodePosX;

		// Token: 0x0400467C RID: 18044
		internal static int __PropertyOffset_NodePosY;

		// Token: 0x0400467D RID: 18045
		internal static int __PropertyOffset_NodeWidth;

		// Token: 0x0400467E RID: 18046
		internal static int __PropertyOffset_NodeHeight;

		// Token: 0x0400467F RID: 18047
		internal static int __PropertyOffset_AdvancedPinDisplay;

		// Token: 0x04004680 RID: 18048
		internal static int __PropertyOffset_EnabledState;

		// Token: 0x04004681 RID: 18049
		internal static int __PropertyOffset_bDisplayAsDisabled;

		// Token: 0x04004682 RID: 18050
		internal static byte __PropertyMask_bDisplayAsDisabled;

		// Token: 0x04004683 RID: 18051
		internal static int __PropertyOffset_bUserSetEnabledState;

		// Token: 0x04004684 RID: 18052
		internal static byte __PropertyMask_bUserSetEnabledState;

		// Token: 0x04004685 RID: 18053
		internal static int __PropertyOffset_bIsNodeEnabled_DEPRECATED;

		// Token: 0x04004686 RID: 18054
		internal static byte __PropertyMask_bIsNodeEnabled_DEPRECATED;

		// Token: 0x04004687 RID: 18055
		internal static int __PropertyOffset_bHasCompilerMessage;

		// Token: 0x04004688 RID: 18056
		internal static byte __PropertyMask_bHasCompilerMessage;

		// Token: 0x04004689 RID: 18057
		internal static int __PropertyOffset_NodeComment;

		// Token: 0x0400468A RID: 18058
		internal static int __PropertyOffset_ErrorType;

		// Token: 0x0400468B RID: 18059
		internal static int __PropertyOffset_ErrorMsg;

		// Token: 0x0400468C RID: 18060
		internal static int __PropertyOffset_NodeGuid;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001DD RID: 477
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.EdGraphNode")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UEdGraphNode : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600217D RID: 8573 RVA: 0x0003119D File Offset: 0x0002F39D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEdGraphNode._ClassPtr;
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x000311AC File Offset: 0x0002F3AC
		public UEdGraphNode() : this(BuiltinUtils.AllocNativeUObject(UEdGraphNode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x000311D4 File Offset: 0x0002F3D4
		public UEdGraphNode(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEdGraphNode.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06002180 RID: 8576 RVA: 0x00031207 File Offset: 0x0002F407
		// (set) Token: 0x06002181 RID: 8577 RVA: 0x00031217 File Offset: 0x0002F417
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

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06002182 RID: 8578 RVA: 0x00031228 File Offset: 0x0002F428
		// (set) Token: 0x06002183 RID: 8579 RVA: 0x00031238 File Offset: 0x0002F438
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

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06002184 RID: 8580 RVA: 0x00031249 File Offset: 0x0002F449
		// (set) Token: 0x06002185 RID: 8581 RVA: 0x00031259 File Offset: 0x0002F459
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

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06002186 RID: 8582 RVA: 0x0003126A File Offset: 0x0002F46A
		// (set) Token: 0x06002187 RID: 8583 RVA: 0x0003127A File Offset: 0x0002F47A
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

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06002188 RID: 8584 RVA: 0x0003128B File Offset: 0x0002F48B
		// (set) Token: 0x06002189 RID: 8585 RVA: 0x000312A4 File Offset: 0x0002F4A4
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

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x0600218A RID: 8586 RVA: 0x000312D4 File Offset: 0x0002F4D4
		// (set) Token: 0x0600218B RID: 8587 RVA: 0x000312ED File Offset: 0x0002F4ED
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

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x0600218C RID: 8588 RVA: 0x0003131D File Offset: 0x0002F51D
		// (set) Token: 0x0600218D RID: 8589 RVA: 0x00031336 File Offset: 0x0002F536
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

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x0600218E RID: 8590 RVA: 0x00031366 File Offset: 0x0002F566
		// (set) Token: 0x0600218F RID: 8591 RVA: 0x0003137F File Offset: 0x0002F57F
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

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06002190 RID: 8592 RVA: 0x000313AF File Offset: 0x0002F5AF
		// (set) Token: 0x06002191 RID: 8593 RVA: 0x000313C3 File Offset: 0x0002F5C3
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

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06002192 RID: 8594 RVA: 0x000313D8 File Offset: 0x0002F5D8
		// (set) Token: 0x06002193 RID: 8595 RVA: 0x000313E8 File Offset: 0x0002F5E8
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

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06002194 RID: 8596 RVA: 0x000313F9 File Offset: 0x0002F5F9
		// (set) Token: 0x06002195 RID: 8597 RVA: 0x0003140D File Offset: 0x0002F60D
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

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06002196 RID: 8598 RVA: 0x00031422 File Offset: 0x0002F622
		// (set) Token: 0x06002197 RID: 8599 RVA: 0x00031436 File Offset: 0x0002F636
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

		// Token: 0x06002198 RID: 8600 RVA: 0x0003144B File Offset: 0x0002F64B
		static UEdGraphNode()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.EdGraphNode");
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x00031459 File Offset: 0x0002F659
		protected UEdGraphNode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000BB6 RID: 2998
		public new const string __ObjectPath = "/Script/Engine.EdGraphNode";

		// Token: 0x04000BB7 RID: 2999
		private static IntPtr _ClassPtr;

		// Token: 0x04000BB8 RID: 3000
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000BB9 RID: 3001
		internal static int __PropertyOffset_NodePosX;

		// Token: 0x04000BBA RID: 3002
		internal static int __PropertyOffset_NodePosY;

		// Token: 0x04000BBB RID: 3003
		internal static int __PropertyOffset_NodeWidth;

		// Token: 0x04000BBC RID: 3004
		internal static int __PropertyOffset_NodeHeight;

		// Token: 0x04000BBD RID: 3005
		internal static int __PropertyOffset_bDisplayAsDisabled;

		// Token: 0x04000BBE RID: 3006
		internal static byte __PropertyMask_bDisplayAsDisabled;

		// Token: 0x04000BBF RID: 3007
		internal static int __PropertyOffset_bUserSetEnabledState;

		// Token: 0x04000BC0 RID: 3008
		internal static byte __PropertyMask_bUserSetEnabledState;

		// Token: 0x04000BC1 RID: 3009
		internal static int __PropertyOffset_bIsNodeEnabled_DEPRECATED;

		// Token: 0x04000BC2 RID: 3010
		internal static byte __PropertyMask_bIsNodeEnabled_DEPRECATED;

		// Token: 0x04000BC3 RID: 3011
		internal static int __PropertyOffset_bHasCompilerMessage;

		// Token: 0x04000BC4 RID: 3012
		internal static byte __PropertyMask_bHasCompilerMessage;

		// Token: 0x04000BC5 RID: 3013
		internal static int __PropertyOffset_NodeComment;

		// Token: 0x04000BC6 RID: 3014
		internal static int __PropertyOffset_ErrorType;

		// Token: 0x04000BC7 RID: 3015
		internal static int __PropertyOffset_ErrorMsg;

		// Token: 0x04000BC8 RID: 3016
		internal static int __PropertyOffset_NodeGuid;
	}
}

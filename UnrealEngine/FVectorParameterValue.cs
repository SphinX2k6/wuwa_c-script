using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001226 RID: 4646
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.VectorParameterValue")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FVectorParameterValue : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011193 RID: 70035 RVA: 0x00191713 File Offset: 0x0018F913
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVectorParameterValue._ScriptStructPtr != 0) ? FVectorParameterValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.VectorParameterValue", ref FVectorParameterValue._ScriptStructPtr);
		}

		// Token: 0x170042C4 RID: 17092
		// (get) Token: 0x06011194 RID: 70036 RVA: 0x00191738 File Offset: 0x0018F938
		// (set) Token: 0x06011195 RID: 70037 RVA: 0x0019177B File Offset: 0x0018F97B
		public FMaterialParameterInfo ParameterInfo
		{
			get
			{
				base.FastCheckIsValid();
				FMaterialParameterInfo result;
				if ((result = this._ParameterInfo) == null)
				{
					result = (this._ParameterInfo = new FMaterialParameterInfo(base.NativePtr + (IntPtr)FVectorParameterValue.__PropertyOffset_ParameterInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialParameterInfo.StaticStruct(), base.NativePtr + (IntPtr)FVectorParameterValue.__PropertyOffset_ParameterInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170042C5 RID: 17093
		// (get) Token: 0x06011196 RID: 70038 RVA: 0x0019179C File Offset: 0x0018F99C
		// (set) Token: 0x06011197 RID: 70039 RVA: 0x001917B0 File Offset: 0x0018F9B0
		public unsafe FLinearColor ParameterValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVectorParameterValue.__PropertyOffset_ParameterValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVectorParameterValue.__PropertyOffset_ParameterValue) = value;
			}
		}

		// Token: 0x170042C6 RID: 17094
		// (get) Token: 0x06011198 RID: 70040 RVA: 0x001917C5 File Offset: 0x0018F9C5
		// (set) Token: 0x06011199 RID: 70041 RVA: 0x001917D9 File Offset: 0x0018F9D9
		public unsafe FGuid ExpressionGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVectorParameterValue.__PropertyOffset_ExpressionGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVectorParameterValue.__PropertyOffset_ExpressionGUID) = value;
			}
		}

		// Token: 0x0601119A RID: 70042 RVA: 0x001917EE File Offset: 0x0018F9EE
		public FVectorParameterValue()
		{
		}

		// Token: 0x0601119B RID: 70043 RVA: 0x001917F6 File Offset: 0x0018F9F6
		public FVectorParameterValue(FName ParameterName_DEPRECATED, FMaterialParameterInfo ParameterInfo, FLinearColor ParameterValue, FGuid ExpressionGUID)
		{
			this.ParameterInfo = ParameterInfo;
			this.ParameterValue = ParameterValue;
			this.ExpressionGUID = ExpressionGUID;
		}

		// Token: 0x0601119C RID: 70044 RVA: 0x00191814 File Offset: 0x0018FA14
		protected override IntPtr GetUStructPtr()
		{
			return FVectorParameterValue.StaticStruct();
		}

		// Token: 0x0601119D RID: 70045 RVA: 0x00191820 File Offset: 0x0018FA20
		[NullableContext(2)]
		public FVectorParameterValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601119E RID: 70046 RVA: 0x0019182A File Offset: 0x0018FA2A
		public FVectorParameterValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601119F RID: 70047 RVA: 0x00191835 File Offset: 0x0018FA35
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVectorParameterValue(Pointer, false, true);
		}

		// Token: 0x060111A0 RID: 70048 RVA: 0x0019183F File Offset: 0x0018FA3F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVectorParameterValue(Pointer, MemoryOwner);
		}

		// Token: 0x04009275 RID: 37493
		public const string __ObjectPath = "/Script/Engine.VectorParameterValue";

		// Token: 0x04009276 RID: 37494
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009277 RID: 37495
		internal static int __PropertyOffset_ParameterInfo;

		// Token: 0x04009278 RID: 37496
		[Nullable(2)]
		private FMaterialParameterInfo _ParameterInfo;

		// Token: 0x04009279 RID: 37497
		internal static int __PropertyOffset_ParameterValue;

		// Token: 0x0400927A RID: 37498
		internal static int __PropertyOffset_ExpressionGUID;
	}
}

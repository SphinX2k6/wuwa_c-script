using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014A3 RID: 5283
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniAssetBlueprintOutput")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class FHoudiniAssetBlueprintOutput : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06013235 RID: 78389 RVA: 0x001C25EC File Offset: 0x001C07EC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHoudiniAssetBlueprintOutput._ScriptStructPtr != 0) ? FHoudiniAssetBlueprintOutput._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniEngineRuntime.HoudiniAssetBlueprintOutput", ref FHoudiniAssetBlueprintOutput._ScriptStructPtr);
		}

		// Token: 0x17004A61 RID: 19041
		// (get) Token: 0x06013236 RID: 78390 RVA: 0x001C2610 File Offset: 0x001C0810
		// (set) Token: 0x06013237 RID: 78391 RVA: 0x001C2620 File Offset: 0x001C0820
		public unsafe int OutputIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintOutput.__PropertyOffset_OutputIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintOutput.__PropertyOffset_OutputIndex) = value;
			}
		}

		// Token: 0x17004A62 RID: 19042
		// (get) Token: 0x06013238 RID: 78392 RVA: 0x001C2634 File Offset: 0x001C0834
		// (set) Token: 0x06013239 RID: 78393 RVA: 0x001C2677 File Offset: 0x001C0877
		public FHoudiniOutputObject OutputObject
		{
			get
			{
				base.FastCheckIsValid();
				FHoudiniOutputObject result;
				if ((result = this._OutputObject) == null)
				{
					result = (this._OutputObject = new FHoudiniOutputObject(base.NativePtr + (IntPtr)FHoudiniAssetBlueprintOutput.__PropertyOffset_OutputObject, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FHoudiniOutputObject.StaticStruct(), base.NativePtr + (IntPtr)FHoudiniAssetBlueprintOutput.__PropertyOffset_OutputObject, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601323A RID: 78394 RVA: 0x001C2698 File Offset: 0x001C0898
		public FHoudiniAssetBlueprintOutput()
		{
		}

		// Token: 0x0601323B RID: 78395 RVA: 0x001C26A0 File Offset: 0x001C08A0
		public FHoudiniAssetBlueprintOutput(int OutputIndex, FHoudiniOutputObject OutputObject)
		{
			this.OutputIndex = OutputIndex;
			this.OutputObject = OutputObject;
		}

		// Token: 0x0601323C RID: 78396 RVA: 0x001C26B6 File Offset: 0x001C08B6
		protected override IntPtr GetUStructPtr()
		{
			return FHoudiniAssetBlueprintOutput.StaticStruct();
		}

		// Token: 0x0601323D RID: 78397 RVA: 0x001C26C2 File Offset: 0x001C08C2
		[NullableContext(2)]
		public FHoudiniAssetBlueprintOutput(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601323E RID: 78398 RVA: 0x001C26CC File Offset: 0x001C08CC
		public FHoudiniAssetBlueprintOutput(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601323F RID: 78399 RVA: 0x001C26D7 File Offset: 0x001C08D7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHoudiniAssetBlueprintOutput(Pointer, false, true);
		}

		// Token: 0x06013240 RID: 78400 RVA: 0x001C26E1 File Offset: 0x001C08E1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHoudiniAssetBlueprintOutput(Pointer, MemoryOwner);
		}

		// Token: 0x0400A54D RID: 42317
		public const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniAssetBlueprintOutput";

		// Token: 0x0400A54E RID: 42318
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A54F RID: 42319
		internal static int __PropertyOffset_OutputIndex;

		// Token: 0x0400A550 RID: 42320
		internal static int __PropertyOffset_OutputObject;

		// Token: 0x0400A551 RID: 42321
		[Nullable(2)]
		private FHoudiniOutputObject _OutputObject;
	}
}

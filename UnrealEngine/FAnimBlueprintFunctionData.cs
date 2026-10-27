using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007EE RID: 2030
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimBlueprintFunctionData")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FAnimBlueprintFunctionData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006C4E RID: 27726 RVA: 0x0009BBBF File Offset: 0x00099DBF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimBlueprintFunctionData._ScriptStructPtr != 0) ? FAnimBlueprintFunctionData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimBlueprintFunctionData", ref FAnimBlueprintFunctionData._ScriptStructPtr);
		}

		// Token: 0x17001986 RID: 6534
		// (get) Token: 0x06006C4F RID: 27727 RVA: 0x0009BBE3 File Offset: 0x00099DE3
		// (set) Token: 0x06006C50 RID: 27728 RVA: 0x0009BBF3 File Offset: 0x00099DF3
		public unsafe Unusable OutputPoseNodeProperty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimBlueprintFunctionData.__PropertyOffset_OutputPoseNodeProperty);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimBlueprintFunctionData.__PropertyOffset_OutputPoseNodeProperty) = value;
			}
		}

		// Token: 0x17001987 RID: 6535
		// (get) Token: 0x06006C51 RID: 27729 RVA: 0x0009BC04 File Offset: 0x00099E04
		// (set) Token: 0x06006C52 RID: 27730 RVA: 0x0009BC47 File Offset: 0x00099E47
		public TArray<Unusable> InputPoseNodeProperties
		{
			get
			{
				base.FastCheckIsValid();
				TArray<Unusable> result;
				if ((result = this._InputPoseNodeProperties) == null)
				{
					result = (this._InputPoseNodeProperties = new TArray<Unusable>(base.NativePtr + (IntPtr)FAnimBlueprintFunctionData.__PropertyOffset_InputPoseNodeProperties, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InputPoseNodeProperties.CopyAssign(value);
			}
		}

		// Token: 0x17001988 RID: 6536
		// (get) Token: 0x06006C53 RID: 27731 RVA: 0x0009BC58 File Offset: 0x00099E58
		// (set) Token: 0x06006C54 RID: 27732 RVA: 0x0009BC9B File Offset: 0x00099E9B
		public TArray<Unusable> InputProperties
		{
			get
			{
				base.FastCheckIsValid();
				TArray<Unusable> result;
				if ((result = this._InputProperties) == null)
				{
					result = (this._InputProperties = new TArray<Unusable>(base.NativePtr + (IntPtr)FAnimBlueprintFunctionData.__PropertyOffset_InputProperties, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InputProperties.CopyAssign(value);
			}
		}

		// Token: 0x06006C55 RID: 27733 RVA: 0x0009BCA9 File Offset: 0x00099EA9
		public FAnimBlueprintFunctionData()
		{
		}

		// Token: 0x06006C56 RID: 27734 RVA: 0x0009BCB1 File Offset: 0x00099EB1
		public FAnimBlueprintFunctionData(Unusable OutputPoseNodeProperty, TArray<Unusable> InputPoseNodeProperties, TArray<Unusable> InputProperties)
		{
			this.OutputPoseNodeProperty = OutputPoseNodeProperty;
			this.InputPoseNodeProperties = InputPoseNodeProperties;
			this.InputProperties = InputProperties;
		}

		// Token: 0x06006C57 RID: 27735 RVA: 0x0009BCCE File Offset: 0x00099ECE
		protected override IntPtr GetUStructPtr()
		{
			return FAnimBlueprintFunctionData.StaticStruct();
		}

		// Token: 0x06006C58 RID: 27736 RVA: 0x0009BCDA File Offset: 0x00099EDA
		[NullableContext(2)]
		public FAnimBlueprintFunctionData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006C59 RID: 27737 RVA: 0x0009BCE4 File Offset: 0x00099EE4
		public FAnimBlueprintFunctionData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006C5A RID: 27738 RVA: 0x0009BCEF File Offset: 0x00099EEF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimBlueprintFunctionData(Pointer, false, true);
		}

		// Token: 0x06006C5B RID: 27739 RVA: 0x0009BCF9 File Offset: 0x00099EF9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimBlueprintFunctionData(Pointer, MemoryOwner);
		}

		// Token: 0x0400341D RID: 13341
		public const string __ObjectPath = "/Script/Engine.AnimBlueprintFunctionData";

		// Token: 0x0400341E RID: 13342
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400341F RID: 13343
		internal static int __PropertyOffset_OutputPoseNodeProperty;

		// Token: 0x04003420 RID: 13344
		internal static int __PropertyOffset_InputPoseNodeProperties;

		// Token: 0x04003421 RID: 13345
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<Unusable> _InputPoseNodeProperties;

		// Token: 0x04003422 RID: 13346
		internal static int __PropertyOffset_InputProperties;

		// Token: 0x04003423 RID: 13347
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<Unusable> _InputProperties;
	}
}

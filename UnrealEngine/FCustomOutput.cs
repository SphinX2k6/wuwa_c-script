using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200098D RID: 2445
	[UnrealObjectPath("/Script/Engine.CustomOutput")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FCustomOutput : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008A25 RID: 35365 RVA: 0x000C5DAA File Offset: 0x000C3FAA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCustomOutput._ScriptStructPtr != 0) ? FCustomOutput._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CustomOutput", ref FCustomOutput._ScriptStructPtr);
		}

		// Token: 0x1700208E RID: 8334
		// (get) Token: 0x06008A26 RID: 35366 RVA: 0x000C5DCE File Offset: 0x000C3FCE
		// (set) Token: 0x06008A27 RID: 35367 RVA: 0x000C5DE2 File Offset: 0x000C3FE2
		public unsafe FName OutputName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCustomOutput.__PropertyOffset_OutputName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCustomOutput.__PropertyOffset_OutputName) = value;
			}
		}

		// Token: 0x1700208F RID: 8335
		// (get) Token: 0x06008A28 RID: 35368 RVA: 0x000C5DF7 File Offset: 0x000C3FF7
		// (set) Token: 0x06008A29 RID: 35369 RVA: 0x000C5E0B File Offset: 0x000C400B
		public unsafe TEnumAsByte<ECustomMaterialOutputType> OutputType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCustomOutput.__PropertyOffset_OutputType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCustomOutput.__PropertyOffset_OutputType) = value;
			}
		}

		// Token: 0x06008A2A RID: 35370 RVA: 0x000C5E20 File Offset: 0x000C4020
		public FCustomOutput()
		{
		}

		// Token: 0x06008A2B RID: 35371 RVA: 0x000C5E28 File Offset: 0x000C4028
		public FCustomOutput(FName OutputName, TEnumAsByte<ECustomMaterialOutputType> OutputType)
		{
			this.OutputName = OutputName;
			this.OutputType = OutputType;
		}

		// Token: 0x06008A2C RID: 35372 RVA: 0x000C5E3E File Offset: 0x000C403E
		protected override IntPtr GetUStructPtr()
		{
			return FCustomOutput.StaticStruct();
		}

		// Token: 0x06008A2D RID: 35373 RVA: 0x000C5E4A File Offset: 0x000C404A
		[NullableContext(2)]
		public FCustomOutput(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008A2E RID: 35374 RVA: 0x000C5E54 File Offset: 0x000C4054
		public FCustomOutput(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008A2F RID: 35375 RVA: 0x000C5E5F File Offset: 0x000C405F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCustomOutput(Pointer, false, true);
		}

		// Token: 0x06008A30 RID: 35376 RVA: 0x000C5E69 File Offset: 0x000C4069
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCustomOutput(Pointer, MemoryOwner);
		}

		// Token: 0x04004194 RID: 16788
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CustomOutput";

		// Token: 0x04004195 RID: 16789
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004196 RID: 16790
		internal static int __PropertyOffset_OutputName;

		// Token: 0x04004197 RID: 16791
		internal static int __PropertyOffset_OutputType;
	}
}

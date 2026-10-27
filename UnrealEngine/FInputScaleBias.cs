using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C5D RID: 3165
	[UnrealObjectPath("/Script/Engine.InputScaleBias")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FInputScaleBias : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A06F RID: 41071 RVA: 0x000E3EC6 File Offset: 0x000E20C6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInputScaleBias._ScriptStructPtr != 0) ? FInputScaleBias._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InputScaleBias", ref FInputScaleBias._ScriptStructPtr);
		}

		// Token: 0x17002631 RID: 9777
		// (get) Token: 0x0600A070 RID: 41072 RVA: 0x000E3EEA File Offset: 0x000E20EA
		// (set) Token: 0x0600A071 RID: 41073 RVA: 0x000E3EFA File Offset: 0x000E20FA
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputScaleBias.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputScaleBias.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17002632 RID: 9778
		// (get) Token: 0x0600A072 RID: 41074 RVA: 0x000E3F0B File Offset: 0x000E210B
		// (set) Token: 0x0600A073 RID: 41075 RVA: 0x000E3F1B File Offset: 0x000E211B
		public unsafe float Bias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputScaleBias.__PropertyOffset_Bias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputScaleBias.__PropertyOffset_Bias) = value;
			}
		}

		// Token: 0x0600A074 RID: 41076 RVA: 0x000E3F2C File Offset: 0x000E212C
		public FInputScaleBias()
		{
		}

		// Token: 0x0600A075 RID: 41077 RVA: 0x000E3F34 File Offset: 0x000E2134
		public FInputScaleBias(float Scale, float Bias)
		{
			this.Scale = Scale;
			this.Bias = Bias;
		}

		// Token: 0x0600A076 RID: 41078 RVA: 0x000E3F4A File Offset: 0x000E214A
		protected override IntPtr GetUStructPtr()
		{
			return FInputScaleBias.StaticStruct();
		}

		// Token: 0x0600A077 RID: 41079 RVA: 0x000E3F56 File Offset: 0x000E2156
		[NullableContext(2)]
		public FInputScaleBias(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A078 RID: 41080 RVA: 0x000E3F60 File Offset: 0x000E2160
		public FInputScaleBias(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A079 RID: 41081 RVA: 0x000E3F6B File Offset: 0x000E216B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInputScaleBias(Pointer, false, true);
		}

		// Token: 0x0600A07A RID: 41082 RVA: 0x000E3F75 File Offset: 0x000E2175
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInputScaleBias(Pointer, MemoryOwner);
		}

		// Token: 0x04005836 RID: 22582
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.InputScaleBias";

		// Token: 0x04005837 RID: 22583
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005838 RID: 22584
		internal static int __PropertyOffset_Scale;

		// Token: 0x04005839 RID: 22585
		internal static int __PropertyOffset_Bias;
	}
}

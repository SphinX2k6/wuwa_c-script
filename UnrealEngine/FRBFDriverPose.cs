using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200106D RID: 4205
	[UnrealObjectPath("/Script/Engine.RBFDriverPose")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FRBFDriverPose : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EF42 RID: 61250 RVA: 0x00162D86 File Offset: 0x00160F86
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRBFDriverPose._ScriptStructPtr != 0) ? FRBFDriverPose._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RBFDriverPose", ref FRBFDriverPose._ScriptStructPtr);
		}

		// Token: 0x170039E9 RID: 14825
		// (get) Token: 0x0600EF43 RID: 61251 RVA: 0x00162DAA File Offset: 0x00160FAA
		// (set) Token: 0x0600EF44 RID: 61252 RVA: 0x00162DBA File Offset: 0x00160FBA
		public unsafe ERBFDriverAttribute Attribute
		{
			get
			{
				return (ERBFDriverAttribute)(*(base.NativePtr + (IntPtr)FRBFDriverPose.__PropertyOffset_Attribute));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFDriverPose.__PropertyOffset_Attribute) = (int)value;
			}
		}

		// Token: 0x170039EA RID: 14826
		// (get) Token: 0x0600EF45 RID: 61253 RVA: 0x00162DCB File Offset: 0x00160FCB
		// (set) Token: 0x0600EF46 RID: 61254 RVA: 0x00162DDB File Offset: 0x00160FDB
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRBFDriverPose.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFDriverPose.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x0600EF47 RID: 61255 RVA: 0x00162DEC File Offset: 0x00160FEC
		public FRBFDriverPose()
		{
		}

		// Token: 0x0600EF48 RID: 61256 RVA: 0x00162DF4 File Offset: 0x00160FF4
		public FRBFDriverPose(ERBFDriverAttribute Attribute, float Value)
		{
			this.Attribute = Attribute;
			this.Value = Value;
		}

		// Token: 0x0600EF49 RID: 61257 RVA: 0x00162E0A File Offset: 0x0016100A
		protected override IntPtr GetUStructPtr()
		{
			return FRBFDriverPose.StaticStruct();
		}

		// Token: 0x0600EF4A RID: 61258 RVA: 0x00162E16 File Offset: 0x00161016
		[NullableContext(2)]
		public FRBFDriverPose(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EF4B RID: 61259 RVA: 0x00162E20 File Offset: 0x00161020
		public FRBFDriverPose(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EF4C RID: 61260 RVA: 0x00162E2B File Offset: 0x0016102B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRBFDriverPose(Pointer, false, true);
		}

		// Token: 0x0600EF4D RID: 61261 RVA: 0x00162E35 File Offset: 0x00161035
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRBFDriverPose(Pointer, MemoryOwner);
		}

		// Token: 0x04008179 RID: 33145
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.RBFDriverPose";

		// Token: 0x0400817A RID: 33146
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400817B RID: 33147
		internal static int __PropertyOffset_Attribute;

		// Token: 0x0400817C RID: 33148
		internal static int __PropertyOffset_Value;
	}
}

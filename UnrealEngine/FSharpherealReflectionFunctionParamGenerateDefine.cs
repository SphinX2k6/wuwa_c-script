using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200276E RID: 10094
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Sharphereal.SharpherealReflectionFunctionParamGenerateDefine")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FSharpherealReflectionFunctionParamGenerateDefine : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025BD6 RID: 154582 RVA: 0x003935CE File Offset: 0x003917CE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealReflectionFunctionParamGenerateDefine._ScriptStructPtr != 0) ? FSharpherealReflectionFunctionParamGenerateDefine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Sharphereal.SharpherealReflectionFunctionParamGenerateDefine", ref FSharpherealReflectionFunctionParamGenerateDefine._ScriptStructPtr);
		}

		// Token: 0x1700914A RID: 37194
		// (get) Token: 0x06025BD7 RID: 154583 RVA: 0x003935F2 File Offset: 0x003917F2
		// (set) Token: 0x06025BD8 RID: 154584 RVA: 0x00393606 File Offset: 0x00391806
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSharpherealReflectionFunctionParamGenerateDefine.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSharpherealReflectionFunctionParamGenerateDefine.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x1700914B RID: 37195
		// (get) Token: 0x06025BD9 RID: 154585 RVA: 0x0039361B File Offset: 0x0039181B
		// (set) Token: 0x06025BDA RID: 154586 RVA: 0x0039362B File Offset: 0x0039182B
		public unsafe ESharpherealReflectionUFunctionParamMode Mode
		{
			get
			{
				return (ESharpherealReflectionUFunctionParamMode)(*(base.NativePtr + (IntPtr)FSharpherealReflectionFunctionParamGenerateDefine.__PropertyOffset_Mode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealReflectionFunctionParamGenerateDefine.__PropertyOffset_Mode) = (byte)value;
			}
		}

		// Token: 0x1700914C RID: 37196
		// (get) Token: 0x06025BDB RID: 154587 RVA: 0x0039363C File Offset: 0x0039183C
		// (set) Token: 0x06025BDC RID: 154588 RVA: 0x0039367F File Offset: 0x0039187F
		public TArray<FSharpherealReflectionPropertyTypeGenerateDefine> TypeDefine
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSharpherealReflectionPropertyTypeGenerateDefine> result;
				if ((result = this._TypeDefine) == null)
				{
					result = (this._TypeDefine = new TArray<FSharpherealReflectionPropertyTypeGenerateDefine>(base.NativePtr + (IntPtr)FSharpherealReflectionFunctionParamGenerateDefine.__PropertyOffset_TypeDefine, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TypeDefine.CopyAssign(value);
			}
		}

		// Token: 0x06025BDD RID: 154589 RVA: 0x0039368D File Offset: 0x0039188D
		public FSharpherealReflectionFunctionParamGenerateDefine()
		{
		}

		// Token: 0x06025BDE RID: 154590 RVA: 0x00393695 File Offset: 0x00391895
		public FSharpherealReflectionFunctionParamGenerateDefine(string Name, ESharpherealReflectionUFunctionParamMode Mode, TArray<FSharpherealReflectionPropertyTypeGenerateDefine> TypeDefine)
		{
			this.Name = Name;
			this.Mode = Mode;
			this.TypeDefine = TypeDefine;
		}

		// Token: 0x06025BDF RID: 154591 RVA: 0x003936B2 File Offset: 0x003918B2
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealReflectionFunctionParamGenerateDefine.StaticStruct();
		}

		// Token: 0x06025BE0 RID: 154592 RVA: 0x003936BE File Offset: 0x003918BE
		[NullableContext(2)]
		public FSharpherealReflectionFunctionParamGenerateDefine(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025BE1 RID: 154593 RVA: 0x003936C8 File Offset: 0x003918C8
		public FSharpherealReflectionFunctionParamGenerateDefine(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025BE2 RID: 154594 RVA: 0x003936D3 File Offset: 0x003918D3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealReflectionFunctionParamGenerateDefine(Pointer, false, true);
		}

		// Token: 0x06025BE3 RID: 154595 RVA: 0x003936DD File Offset: 0x003918DD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealReflectionFunctionParamGenerateDefine(Pointer, MemoryOwner);
		}

		// Token: 0x040148B1 RID: 84145
		public const string __ObjectPath = "/Script/Sharphereal.SharpherealReflectionFunctionParamGenerateDefine";

		// Token: 0x040148B2 RID: 84146
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040148B3 RID: 84147
		internal static int __PropertyOffset_Name;

		// Token: 0x040148B4 RID: 84148
		internal static int __PropertyOffset_Mode;

		// Token: 0x040148B5 RID: 84149
		internal static int __PropertyOffset_TypeDefine;

		// Token: 0x040148B6 RID: 84150
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealReflectionPropertyTypeGenerateDefine> _TypeDefine;
	}
}

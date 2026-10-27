using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200276D RID: 10093
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Sharphereal.SharpherealReflectionFunctionGenerateDefine")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FSharpherealReflectionFunctionGenerateDefine : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025BC6 RID: 154566 RVA: 0x00393447 File Offset: 0x00391647
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealReflectionFunctionGenerateDefine._ScriptStructPtr != 0) ? FSharpherealReflectionFunctionGenerateDefine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Sharphereal.SharpherealReflectionFunctionGenerateDefine", ref FSharpherealReflectionFunctionGenerateDefine._ScriptStructPtr);
		}

		// Token: 0x17009146 RID: 37190
		// (get) Token: 0x06025BC7 RID: 154567 RVA: 0x0039346B File Offset: 0x0039166B
		// (set) Token: 0x06025BC8 RID: 154568 RVA: 0x0039347F File Offset: 0x0039167F
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSharpherealReflectionFunctionGenerateDefine.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSharpherealReflectionFunctionGenerateDefine.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17009147 RID: 37191
		// (get) Token: 0x06025BC9 RID: 154569 RVA: 0x00393494 File Offset: 0x00391694
		// (set) Token: 0x06025BCA RID: 154570 RVA: 0x003934A4 File Offset: 0x003916A4
		public unsafe uint FuncFlags
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSharpherealReflectionFunctionGenerateDefine.__PropertyOffset_FuncFlags);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealReflectionFunctionGenerateDefine.__PropertyOffset_FuncFlags) = (int)value;
			}
		}

		// Token: 0x17009148 RID: 37192
		// (get) Token: 0x06025BCB RID: 154571 RVA: 0x003934B8 File Offset: 0x003916B8
		// (set) Token: 0x06025BCC RID: 154572 RVA: 0x003934FB File Offset: 0x003916FB
		public FSharpherealReflectionFunctionParamGenerateDefine ReturnType
		{
			get
			{
				base.FastCheckIsValid();
				FSharpherealReflectionFunctionParamGenerateDefine result;
				if ((result = this._ReturnType) == null)
				{
					result = (this._ReturnType = new FSharpherealReflectionFunctionParamGenerateDefine(base.NativePtr + (IntPtr)FSharpherealReflectionFunctionGenerateDefine.__PropertyOffset_ReturnType, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSharpherealReflectionFunctionParamGenerateDefine.StaticStruct(), base.NativePtr + (IntPtr)FSharpherealReflectionFunctionGenerateDefine.__PropertyOffset_ReturnType, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009149 RID: 37193
		// (get) Token: 0x06025BCD RID: 154573 RVA: 0x0039351C File Offset: 0x0039171C
		// (set) Token: 0x06025BCE RID: 154574 RVA: 0x0039355F File Offset: 0x0039175F
		public TArray<FSharpherealReflectionFunctionParamGenerateDefine> ParamType
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSharpherealReflectionFunctionParamGenerateDefine> result;
				if ((result = this._ParamType) == null)
				{
					result = (this._ParamType = new TArray<FSharpherealReflectionFunctionParamGenerateDefine>(base.NativePtr + (IntPtr)FSharpherealReflectionFunctionGenerateDefine.__PropertyOffset_ParamType, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ParamType.CopyAssign(value);
			}
		}

		// Token: 0x06025BCF RID: 154575 RVA: 0x0039356D File Offset: 0x0039176D
		public FSharpherealReflectionFunctionGenerateDefine()
		{
		}

		// Token: 0x06025BD0 RID: 154576 RVA: 0x00393575 File Offset: 0x00391775
		public FSharpherealReflectionFunctionGenerateDefine(string Name, uint FuncFlags, FSharpherealReflectionFunctionParamGenerateDefine ReturnType, TArray<FSharpherealReflectionFunctionParamGenerateDefine> ParamType)
		{
			this.Name = Name;
			this.FuncFlags = FuncFlags;
			this.ReturnType = ReturnType;
			this.ParamType = ParamType;
		}

		// Token: 0x06025BD1 RID: 154577 RVA: 0x0039359A File Offset: 0x0039179A
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealReflectionFunctionGenerateDefine.StaticStruct();
		}

		// Token: 0x06025BD2 RID: 154578 RVA: 0x003935A6 File Offset: 0x003917A6
		[NullableContext(2)]
		public FSharpherealReflectionFunctionGenerateDefine(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025BD3 RID: 154579 RVA: 0x003935B0 File Offset: 0x003917B0
		public FSharpherealReflectionFunctionGenerateDefine(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025BD4 RID: 154580 RVA: 0x003935BB File Offset: 0x003917BB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealReflectionFunctionGenerateDefine(Pointer, false, true);
		}

		// Token: 0x06025BD5 RID: 154581 RVA: 0x003935C5 File Offset: 0x003917C5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealReflectionFunctionGenerateDefine(Pointer, MemoryOwner);
		}

		// Token: 0x040148A9 RID: 84137
		public const string __ObjectPath = "/Script/Sharphereal.SharpherealReflectionFunctionGenerateDefine";

		// Token: 0x040148AA RID: 84138
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040148AB RID: 84139
		internal static int __PropertyOffset_Name;

		// Token: 0x040148AC RID: 84140
		internal static int __PropertyOffset_FuncFlags;

		// Token: 0x040148AD RID: 84141
		internal static int __PropertyOffset_ReturnType;

		// Token: 0x040148AE RID: 84142
		[Nullable(2)]
		private FSharpherealReflectionFunctionParamGenerateDefine _ReturnType;

		// Token: 0x040148AF RID: 84143
		internal static int __PropertyOffset_ParamType;

		// Token: 0x040148B0 RID: 84144
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealReflectionFunctionParamGenerateDefine> _ParamType;
	}
}

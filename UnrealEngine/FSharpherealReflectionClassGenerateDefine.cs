using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002769 RID: 10089
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Sharphereal.SharpherealReflectionClassGenerateDefine")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FSharpherealReflectionClassGenerateDefine : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025B90 RID: 154512 RVA: 0x00392F9F File Offset: 0x0039119F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealReflectionClassGenerateDefine._ScriptStructPtr != 0) ? FSharpherealReflectionClassGenerateDefine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Sharphereal.SharpherealReflectionClassGenerateDefine", ref FSharpherealReflectionClassGenerateDefine._ScriptStructPtr);
		}

		// Token: 0x1700913B RID: 37179
		// (get) Token: 0x06025B91 RID: 154513 RVA: 0x00392FC3 File Offset: 0x003911C3
		// (set) Token: 0x06025B92 RID: 154514 RVA: 0x00392FD7 File Offset: 0x003911D7
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSharpherealReflectionClassGenerateDefine.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSharpherealReflectionClassGenerateDefine.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x1700913C RID: 37180
		// (get) Token: 0x06025B93 RID: 154515 RVA: 0x00392FEC File Offset: 0x003911EC
		// (set) Token: 0x06025B94 RID: 154516 RVA: 0x00393000 File Offset: 0x00391200
		public unsafe string Super
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSharpherealReflectionClassGenerateDefine.__PropertyOffset_Super)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSharpherealReflectionClassGenerateDefine.__PropertyOffset_Super)), value);
			}
		}

		// Token: 0x1700913D RID: 37181
		// (get) Token: 0x06025B95 RID: 154517 RVA: 0x00393018 File Offset: 0x00391218
		// (set) Token: 0x06025B96 RID: 154518 RVA: 0x0039305B File Offset: 0x0039125B
		public TArray<FSharpherealReflectionPropertyGenerateDefine> PropertyDefine
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSharpherealReflectionPropertyGenerateDefine> result;
				if ((result = this._PropertyDefine) == null)
				{
					result = (this._PropertyDefine = new TArray<FSharpherealReflectionPropertyGenerateDefine>(base.NativePtr + (IntPtr)FSharpherealReflectionClassGenerateDefine.__PropertyOffset_PropertyDefine, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PropertyDefine.CopyAssign(value);
			}
		}

		// Token: 0x1700913E RID: 37182
		// (get) Token: 0x06025B97 RID: 154519 RVA: 0x0039306C File Offset: 0x0039126C
		// (set) Token: 0x06025B98 RID: 154520 RVA: 0x003930AF File Offset: 0x003912AF
		public TArray<FSharpherealReflectionFunctionGenerateDefine> FunctionDefine
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSharpherealReflectionFunctionGenerateDefine> result;
				if ((result = this._FunctionDefine) == null)
				{
					result = (this._FunctionDefine = new TArray<FSharpherealReflectionFunctionGenerateDefine>(base.NativePtr + (IntPtr)FSharpherealReflectionClassGenerateDefine.__PropertyOffset_FunctionDefine, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FunctionDefine.CopyAssign(value);
			}
		}

		// Token: 0x06025B99 RID: 154521 RVA: 0x003930BD File Offset: 0x003912BD
		public FSharpherealReflectionClassGenerateDefine()
		{
		}

		// Token: 0x06025B9A RID: 154522 RVA: 0x003930C5 File Offset: 0x003912C5
		public FSharpherealReflectionClassGenerateDefine(string Name, string Super, TArray<FSharpherealReflectionPropertyGenerateDefine> PropertyDefine, TArray<FSharpherealReflectionFunctionGenerateDefine> FunctionDefine)
		{
			this.Name = Name;
			this.Super = Super;
			this.PropertyDefine = PropertyDefine;
			this.FunctionDefine = FunctionDefine;
		}

		// Token: 0x06025B9B RID: 154523 RVA: 0x003930EA File Offset: 0x003912EA
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealReflectionClassGenerateDefine.StaticStruct();
		}

		// Token: 0x06025B9C RID: 154524 RVA: 0x003930F6 File Offset: 0x003912F6
		[NullableContext(2)]
		public FSharpherealReflectionClassGenerateDefine(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025B9D RID: 154525 RVA: 0x00393100 File Offset: 0x00391300
		public FSharpherealReflectionClassGenerateDefine(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025B9E RID: 154526 RVA: 0x0039310B File Offset: 0x0039130B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealReflectionClassGenerateDefine(Pointer, false, true);
		}

		// Token: 0x06025B9F RID: 154527 RVA: 0x00393115 File Offset: 0x00391315
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealReflectionClassGenerateDefine(Pointer, MemoryOwner);
		}

		// Token: 0x04014890 RID: 84112
		public const string __ObjectPath = "/Script/Sharphereal.SharpherealReflectionClassGenerateDefine";

		// Token: 0x04014891 RID: 84113
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014892 RID: 84114
		internal static int __PropertyOffset_Name;

		// Token: 0x04014893 RID: 84115
		internal static int __PropertyOffset_Super;

		// Token: 0x04014894 RID: 84116
		internal static int __PropertyOffset_PropertyDefine;

		// Token: 0x04014895 RID: 84117
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealReflectionPropertyGenerateDefine> _PropertyDefine;

		// Token: 0x04014896 RID: 84118
		internal static int __PropertyOffset_FunctionDefine;

		// Token: 0x04014897 RID: 84119
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealReflectionFunctionGenerateDefine> _FunctionDefine;
	}
}

using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200276A RID: 10090
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Sharphereal.SharpherealReflectionCollectGeneratorDefine")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FSharpherealReflectionCollectGeneratorDefine : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025BA0 RID: 154528 RVA: 0x0039311E File Offset: 0x0039131E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealReflectionCollectGeneratorDefine._ScriptStructPtr != 0) ? FSharpherealReflectionCollectGeneratorDefine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Sharphereal.SharpherealReflectionCollectGeneratorDefine", ref FSharpherealReflectionCollectGeneratorDefine._ScriptStructPtr);
		}

		// Token: 0x1700913F RID: 37183
		// (get) Token: 0x06025BA1 RID: 154529 RVA: 0x00393144 File Offset: 0x00391344
		// (set) Token: 0x06025BA2 RID: 154530 RVA: 0x00393187 File Offset: 0x00391387
		public TArray<FSharpherealReflectionEnumGenerateDefine> EnumDefines
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSharpherealReflectionEnumGenerateDefine> result;
				if ((result = this._EnumDefines) == null)
				{
					result = (this._EnumDefines = new TArray<FSharpherealReflectionEnumGenerateDefine>(base.NativePtr + (IntPtr)FSharpherealReflectionCollectGeneratorDefine.__PropertyOffset_EnumDefines, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EnumDefines.CopyAssign(value);
			}
		}

		// Token: 0x17009140 RID: 37184
		// (get) Token: 0x06025BA3 RID: 154531 RVA: 0x00393198 File Offset: 0x00391398
		// (set) Token: 0x06025BA4 RID: 154532 RVA: 0x003931DB File Offset: 0x003913DB
		public TArray<FSharpherealReflectionStructGenerateDefine> StructDefines
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSharpherealReflectionStructGenerateDefine> result;
				if ((result = this._StructDefines) == null)
				{
					result = (this._StructDefines = new TArray<FSharpherealReflectionStructGenerateDefine>(base.NativePtr + (IntPtr)FSharpherealReflectionCollectGeneratorDefine.__PropertyOffset_StructDefines, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StructDefines.CopyAssign(value);
			}
		}

		// Token: 0x17009141 RID: 37185
		// (get) Token: 0x06025BA5 RID: 154533 RVA: 0x003931EC File Offset: 0x003913EC
		// (set) Token: 0x06025BA6 RID: 154534 RVA: 0x0039322F File Offset: 0x0039142F
		public TArray<FSharpherealReflectionClassGenerateDefine> ClassDefines
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSharpherealReflectionClassGenerateDefine> result;
				if ((result = this._ClassDefines) == null)
				{
					result = (this._ClassDefines = new TArray<FSharpherealReflectionClassGenerateDefine>(base.NativePtr + (IntPtr)FSharpherealReflectionCollectGeneratorDefine.__PropertyOffset_ClassDefines, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ClassDefines.CopyAssign(value);
			}
		}

		// Token: 0x06025BA7 RID: 154535 RVA: 0x0039323D File Offset: 0x0039143D
		public FSharpherealReflectionCollectGeneratorDefine()
		{
		}

		// Token: 0x06025BA8 RID: 154536 RVA: 0x00393245 File Offset: 0x00391445
		public FSharpherealReflectionCollectGeneratorDefine(TArray<FSharpherealReflectionEnumGenerateDefine> EnumDefines, TArray<FSharpherealReflectionStructGenerateDefine> StructDefines, TArray<FSharpherealReflectionClassGenerateDefine> ClassDefines)
		{
			this.EnumDefines = EnumDefines;
			this.StructDefines = StructDefines;
			this.ClassDefines = ClassDefines;
		}

		// Token: 0x06025BA9 RID: 154537 RVA: 0x00393262 File Offset: 0x00391462
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealReflectionCollectGeneratorDefine.StaticStruct();
		}

		// Token: 0x06025BAA RID: 154538 RVA: 0x0039326E File Offset: 0x0039146E
		[NullableContext(2)]
		public FSharpherealReflectionCollectGeneratorDefine(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025BAB RID: 154539 RVA: 0x00393278 File Offset: 0x00391478
		public FSharpherealReflectionCollectGeneratorDefine(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025BAC RID: 154540 RVA: 0x00393283 File Offset: 0x00391483
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealReflectionCollectGeneratorDefine(Pointer, false, true);
		}

		// Token: 0x06025BAD RID: 154541 RVA: 0x0039328D File Offset: 0x0039148D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealReflectionCollectGeneratorDefine(Pointer, MemoryOwner);
		}

		// Token: 0x04014898 RID: 84120
		public const string __ObjectPath = "/Script/Sharphereal.SharpherealReflectionCollectGeneratorDefine";

		// Token: 0x04014899 RID: 84121
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401489A RID: 84122
		internal static int __PropertyOffset_EnumDefines;

		// Token: 0x0401489B RID: 84123
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealReflectionEnumGenerateDefine> _EnumDefines;

		// Token: 0x0401489C RID: 84124
		internal static int __PropertyOffset_StructDefines;

		// Token: 0x0401489D RID: 84125
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealReflectionStructGenerateDefine> _StructDefines;

		// Token: 0x0401489E RID: 84126
		internal static int __PropertyOffset_ClassDefines;

		// Token: 0x0401489F RID: 84127
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealReflectionClassGenerateDefine> _ClassDefines;
	}
}

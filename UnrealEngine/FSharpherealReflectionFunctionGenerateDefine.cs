using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000813 RID: 2067
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Sharphereal.SharpherealReflectionFunctionGenerateDefine")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FSharpherealReflectionFunctionGenerateDefine : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B576 RID: 46454 RVA: 0x00120CA9 File Offset: 0x0011EEA9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealReflectionFunctionGenerateDefine._ScriptStructPtr != 0) ? FSharpherealReflectionFunctionGenerateDefine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Sharphereal.SharpherealReflectionFunctionGenerateDefine", ref FSharpherealReflectionFunctionGenerateDefine._ScriptStructPtr);
		}

		// Token: 0x170021F8 RID: 8696
		// (get) Token: 0x0600B577 RID: 46455 RVA: 0x00120CCD File Offset: 0x0011EECD
		// (set) Token: 0x0600B578 RID: 46456 RVA: 0x00120CE1 File Offset: 0x0011EEE1
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

		// Token: 0x170021F9 RID: 8697
		// (get) Token: 0x0600B579 RID: 46457 RVA: 0x00120CF6 File Offset: 0x0011EEF6
		// (set) Token: 0x0600B57A RID: 46458 RVA: 0x00120D06 File Offset: 0x0011EF06
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

		// Token: 0x170021FA RID: 8698
		// (get) Token: 0x0600B57B RID: 46459 RVA: 0x00120D18 File Offset: 0x0011EF18
		// (set) Token: 0x0600B57C RID: 46460 RVA: 0x00120D5B File Offset: 0x0011EF5B
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

		// Token: 0x170021FB RID: 8699
		// (get) Token: 0x0600B57D RID: 46461 RVA: 0x00120D7C File Offset: 0x0011EF7C
		// (set) Token: 0x0600B57E RID: 46462 RVA: 0x00120DBF File Offset: 0x0011EFBF
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

		// Token: 0x0600B57F RID: 46463 RVA: 0x00120DCD File Offset: 0x0011EFCD
		public FSharpherealReflectionFunctionGenerateDefine()
		{
		}

		// Token: 0x0600B580 RID: 46464 RVA: 0x00120DD5 File Offset: 0x0011EFD5
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealReflectionFunctionGenerateDefine.StaticStruct();
		}

		// Token: 0x0600B581 RID: 46465 RVA: 0x00120DE1 File Offset: 0x0011EFE1
		[NullableContext(2)]
		public FSharpherealReflectionFunctionGenerateDefine(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B582 RID: 46466 RVA: 0x00120DEB File Offset: 0x0011EFEB
		public FSharpherealReflectionFunctionGenerateDefine(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B583 RID: 46467 RVA: 0x00120DF6 File Offset: 0x0011EFF6
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealReflectionFunctionGenerateDefine(Pointer, false, true);
		}

		// Token: 0x0600B584 RID: 46468 RVA: 0x00120E00 File Offset: 0x0011F000
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealReflectionFunctionGenerateDefine(Pointer, MemoryOwner);
		}

		// Token: 0x040051E6 RID: 20966
		public const string __ObjectPath = "/Script/Sharphereal.SharpherealReflectionFunctionGenerateDefine";

		// Token: 0x040051E7 RID: 20967
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040051E8 RID: 20968
		internal static int __PropertyOffset_Name;

		// Token: 0x040051E9 RID: 20969
		internal static int __PropertyOffset_FuncFlags;

		// Token: 0x040051EA RID: 20970
		internal static int __PropertyOffset_ReturnType;

		// Token: 0x040051EB RID: 20971
		[Nullable(2)]
		private FSharpherealReflectionFunctionParamGenerateDefine _ReturnType;

		// Token: 0x040051EC RID: 20972
		internal static int __PropertyOffset_ParamType;

		// Token: 0x040051ED RID: 20973
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealReflectionFunctionParamGenerateDefine> _ParamType;
	}
}

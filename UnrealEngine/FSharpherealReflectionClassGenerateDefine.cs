using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000812 RID: 2066
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Sharphereal.SharpherealReflectionClassGenerateDefine")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FSharpherealReflectionClassGenerateDefine : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B567 RID: 46439 RVA: 0x00120B52 File Offset: 0x0011ED52
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealReflectionClassGenerateDefine._ScriptStructPtr != 0) ? FSharpherealReflectionClassGenerateDefine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Sharphereal.SharpherealReflectionClassGenerateDefine", ref FSharpherealReflectionClassGenerateDefine._ScriptStructPtr);
		}

		// Token: 0x170021F4 RID: 8692
		// (get) Token: 0x0600B568 RID: 46440 RVA: 0x00120B76 File Offset: 0x0011ED76
		// (set) Token: 0x0600B569 RID: 46441 RVA: 0x00120B8A File Offset: 0x0011ED8A
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

		// Token: 0x170021F5 RID: 8693
		// (get) Token: 0x0600B56A RID: 46442 RVA: 0x00120B9F File Offset: 0x0011ED9F
		// (set) Token: 0x0600B56B RID: 46443 RVA: 0x00120BB3 File Offset: 0x0011EDB3
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

		// Token: 0x170021F6 RID: 8694
		// (get) Token: 0x0600B56C RID: 46444 RVA: 0x00120BC8 File Offset: 0x0011EDC8
		// (set) Token: 0x0600B56D RID: 46445 RVA: 0x00120C0B File Offset: 0x0011EE0B
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

		// Token: 0x170021F7 RID: 8695
		// (get) Token: 0x0600B56E RID: 46446 RVA: 0x00120C1C File Offset: 0x0011EE1C
		// (set) Token: 0x0600B56F RID: 46447 RVA: 0x00120C5F File Offset: 0x0011EE5F
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

		// Token: 0x0600B570 RID: 46448 RVA: 0x00120C6D File Offset: 0x0011EE6D
		public FSharpherealReflectionClassGenerateDefine()
		{
		}

		// Token: 0x0600B571 RID: 46449 RVA: 0x00120C75 File Offset: 0x0011EE75
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealReflectionClassGenerateDefine.StaticStruct();
		}

		// Token: 0x0600B572 RID: 46450 RVA: 0x00120C81 File Offset: 0x0011EE81
		[NullableContext(2)]
		public FSharpherealReflectionClassGenerateDefine(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B573 RID: 46451 RVA: 0x00120C8B File Offset: 0x0011EE8B
		public FSharpherealReflectionClassGenerateDefine(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B574 RID: 46452 RVA: 0x00120C96 File Offset: 0x0011EE96
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealReflectionClassGenerateDefine(Pointer, false, true);
		}

		// Token: 0x0600B575 RID: 46453 RVA: 0x00120CA0 File Offset: 0x0011EEA0
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealReflectionClassGenerateDefine(Pointer, MemoryOwner);
		}

		// Token: 0x040051DE RID: 20958
		public const string __ObjectPath = "/Script/Sharphereal.SharpherealReflectionClassGenerateDefine";

		// Token: 0x040051DF RID: 20959
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040051E0 RID: 20960
		internal static int __PropertyOffset_Name;

		// Token: 0x040051E1 RID: 20961
		internal static int __PropertyOffset_Super;

		// Token: 0x040051E2 RID: 20962
		internal static int __PropertyOffset_PropertyDefine;

		// Token: 0x040051E3 RID: 20963
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealReflectionPropertyGenerateDefine> _PropertyDefine;

		// Token: 0x040051E4 RID: 20964
		internal static int __PropertyOffset_FunctionDefine;

		// Token: 0x040051E5 RID: 20965
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealReflectionFunctionGenerateDefine> _FunctionDefine;
	}
}

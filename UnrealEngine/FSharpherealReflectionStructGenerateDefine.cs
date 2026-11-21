using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000817 RID: 2071
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Sharphereal.SharpherealReflectionStructGenerateDefine")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FSharpherealReflectionStructGenerateDefine : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B5A8 RID: 46504 RVA: 0x0012108B File Offset: 0x0011F28B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealReflectionStructGenerateDefine._ScriptStructPtr != 0) ? FSharpherealReflectionStructGenerateDefine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Sharphereal.SharpherealReflectionStructGenerateDefine", ref FSharpherealReflectionStructGenerateDefine._ScriptStructPtr);
		}

		// Token: 0x17002203 RID: 8707
		// (get) Token: 0x0600B5A9 RID: 46505 RVA: 0x001210AF File Offset: 0x0011F2AF
		// (set) Token: 0x0600B5AA RID: 46506 RVA: 0x001210C3 File Offset: 0x0011F2C3
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSharpherealReflectionStructGenerateDefine.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSharpherealReflectionStructGenerateDefine.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17002204 RID: 8708
		// (get) Token: 0x0600B5AB RID: 46507 RVA: 0x001210D8 File Offset: 0x0011F2D8
		// (set) Token: 0x0600B5AC RID: 46508 RVA: 0x001210EC File Offset: 0x0011F2EC
		public unsafe string Super
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSharpherealReflectionStructGenerateDefine.__PropertyOffset_Super)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSharpherealReflectionStructGenerateDefine.__PropertyOffset_Super)), value);
			}
		}

		// Token: 0x17002205 RID: 8709
		// (get) Token: 0x0600B5AD RID: 46509 RVA: 0x00121104 File Offset: 0x0011F304
		// (set) Token: 0x0600B5AE RID: 46510 RVA: 0x00121147 File Offset: 0x0011F347
		public TArray<FSharpherealReflectionPropertyGenerateDefine> PropertyDefine
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSharpherealReflectionPropertyGenerateDefine> result;
				if ((result = this._PropertyDefine) == null)
				{
					result = (this._PropertyDefine = new TArray<FSharpherealReflectionPropertyGenerateDefine>(base.NativePtr + (IntPtr)FSharpherealReflectionStructGenerateDefine.__PropertyOffset_PropertyDefine, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PropertyDefine.CopyAssign(value);
			}
		}

		// Token: 0x0600B5AF RID: 46511 RVA: 0x00121155 File Offset: 0x0011F355
		public FSharpherealReflectionStructGenerateDefine()
		{
		}

		// Token: 0x0600B5B0 RID: 46512 RVA: 0x0012115D File Offset: 0x0011F35D
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealReflectionStructGenerateDefine.StaticStruct();
		}

		// Token: 0x0600B5B1 RID: 46513 RVA: 0x00121169 File Offset: 0x0011F369
		[NullableContext(2)]
		public FSharpherealReflectionStructGenerateDefine(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B5B2 RID: 46514 RVA: 0x00121173 File Offset: 0x0011F373
		public FSharpherealReflectionStructGenerateDefine(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B5B3 RID: 46515 RVA: 0x0012117E File Offset: 0x0011F37E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealReflectionStructGenerateDefine(Pointer, false, true);
		}

		// Token: 0x0600B5B4 RID: 46516 RVA: 0x00121188 File Offset: 0x0011F388
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealReflectionStructGenerateDefine(Pointer, MemoryOwner);
		}

		// Token: 0x040051FD RID: 20989
		public const string __ObjectPath = "/Script/Sharphereal.SharpherealReflectionStructGenerateDefine";

		// Token: 0x040051FE RID: 20990
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040051FF RID: 20991
		internal static int __PropertyOffset_Name;

		// Token: 0x04005200 RID: 20992
		internal static int __PropertyOffset_Super;

		// Token: 0x04005201 RID: 20993
		internal static int __PropertyOffset_PropertyDefine;

		// Token: 0x04005202 RID: 20994
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealReflectionPropertyGenerateDefine> _PropertyDefine;
	}
}

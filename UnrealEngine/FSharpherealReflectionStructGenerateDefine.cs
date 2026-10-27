using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002771 RID: 10097
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Sharphereal.SharpherealReflectionStructGenerateDefine")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FSharpherealReflectionStructGenerateDefine : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025BFC RID: 154620 RVA: 0x00393897 File Offset: 0x00391A97
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealReflectionStructGenerateDefine._ScriptStructPtr != 0) ? FSharpherealReflectionStructGenerateDefine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Sharphereal.SharpherealReflectionStructGenerateDefine", ref FSharpherealReflectionStructGenerateDefine._ScriptStructPtr);
		}

		// Token: 0x17009151 RID: 37201
		// (get) Token: 0x06025BFD RID: 154621 RVA: 0x003938BB File Offset: 0x00391ABB
		// (set) Token: 0x06025BFE RID: 154622 RVA: 0x003938CF File Offset: 0x00391ACF
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

		// Token: 0x17009152 RID: 37202
		// (get) Token: 0x06025BFF RID: 154623 RVA: 0x003938E4 File Offset: 0x00391AE4
		// (set) Token: 0x06025C00 RID: 154624 RVA: 0x003938F8 File Offset: 0x00391AF8
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

		// Token: 0x17009153 RID: 37203
		// (get) Token: 0x06025C01 RID: 154625 RVA: 0x00393910 File Offset: 0x00391B10
		// (set) Token: 0x06025C02 RID: 154626 RVA: 0x00393953 File Offset: 0x00391B53
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

		// Token: 0x06025C03 RID: 154627 RVA: 0x00393961 File Offset: 0x00391B61
		public FSharpherealReflectionStructGenerateDefine()
		{
		}

		// Token: 0x06025C04 RID: 154628 RVA: 0x00393969 File Offset: 0x00391B69
		public FSharpherealReflectionStructGenerateDefine(string Name, string Super, TArray<FSharpherealReflectionPropertyGenerateDefine> PropertyDefine)
		{
			this.Name = Name;
			this.Super = Super;
			this.PropertyDefine = PropertyDefine;
		}

		// Token: 0x06025C05 RID: 154629 RVA: 0x00393986 File Offset: 0x00391B86
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealReflectionStructGenerateDefine.StaticStruct();
		}

		// Token: 0x06025C06 RID: 154630 RVA: 0x00393992 File Offset: 0x00391B92
		[NullableContext(2)]
		public FSharpherealReflectionStructGenerateDefine(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025C07 RID: 154631 RVA: 0x0039399C File Offset: 0x00391B9C
		public FSharpherealReflectionStructGenerateDefine(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025C08 RID: 154632 RVA: 0x003939A7 File Offset: 0x00391BA7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealReflectionStructGenerateDefine(Pointer, false, true);
		}

		// Token: 0x06025C09 RID: 154633 RVA: 0x003939B1 File Offset: 0x00391BB1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealReflectionStructGenerateDefine(Pointer, MemoryOwner);
		}

		// Token: 0x040148C0 RID: 84160
		public const string __ObjectPath = "/Script/Sharphereal.SharpherealReflectionStructGenerateDefine";

		// Token: 0x040148C1 RID: 84161
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040148C2 RID: 84162
		internal static int __PropertyOffset_Name;

		// Token: 0x040148C3 RID: 84163
		internal static int __PropertyOffset_Super;

		// Token: 0x040148C4 RID: 84164
		internal static int __PropertyOffset_PropertyDefine;

		// Token: 0x040148C5 RID: 84165
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSharpherealReflectionPropertyGenerateDefine> _PropertyDefine;
	}
}

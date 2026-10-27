using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001057 RID: 4183
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PSOGeneratorConfigVertexInput")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FPSOGeneratorConfigVertexInput : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EDF2 RID: 60914 RVA: 0x0016125C File Offset: 0x0015F45C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPSOGeneratorConfigVertexInput._ScriptStructPtr != 0) ? FPSOGeneratorConfigVertexInput._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PSOGeneratorConfigVertexInput", ref FPSOGeneratorConfigVertexInput._ScriptStructPtr);
		}

		// Token: 0x17003997 RID: 14743
		// (get) Token: 0x0600EDF3 RID: 60915 RVA: 0x00161280 File Offset: 0x0015F480
		// (set) Token: 0x0600EDF4 RID: 60916 RVA: 0x001612C3 File Offset: 0x0015F4C3
		public TArray<FPSOGeneratorConfigVertexInputElement> Elements
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPSOGeneratorConfigVertexInputElement> result;
				if ((result = this._Elements) == null)
				{
					result = (this._Elements = new TArray<FPSOGeneratorConfigVertexInputElement>(base.NativePtr + (IntPtr)FPSOGeneratorConfigVertexInput.__PropertyOffset_Elements, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Elements.CopyAssign(value);
			}
		}

		// Token: 0x0600EDF5 RID: 60917 RVA: 0x001612D1 File Offset: 0x0015F4D1
		public FPSOGeneratorConfigVertexInput()
		{
		}

		// Token: 0x0600EDF6 RID: 60918 RVA: 0x001612D9 File Offset: 0x0015F4D9
		public FPSOGeneratorConfigVertexInput(TArray<FPSOGeneratorConfigVertexInputElement> Elements)
		{
			this.Elements = Elements;
		}

		// Token: 0x0600EDF7 RID: 60919 RVA: 0x001612E8 File Offset: 0x0015F4E8
		protected override IntPtr GetUStructPtr()
		{
			return FPSOGeneratorConfigVertexInput.StaticStruct();
		}

		// Token: 0x0600EDF8 RID: 60920 RVA: 0x001612F4 File Offset: 0x0015F4F4
		[NullableContext(2)]
		public FPSOGeneratorConfigVertexInput(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EDF9 RID: 60921 RVA: 0x001612FE File Offset: 0x0015F4FE
		public FPSOGeneratorConfigVertexInput(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EDFA RID: 60922 RVA: 0x00161309 File Offset: 0x0015F509
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPSOGeneratorConfigVertexInput(Pointer, false, true);
		}

		// Token: 0x0600EDFB RID: 60923 RVA: 0x00161313 File Offset: 0x0015F513
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPSOGeneratorConfigVertexInput(Pointer, MemoryOwner);
		}

		// Token: 0x040080DD RID: 32989
		public const string __ObjectPath = "/Script/Engine.PSOGeneratorConfigVertexInput";

		// Token: 0x040080DE RID: 32990
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040080DF RID: 32991
		internal static int __PropertyOffset_Elements;

		// Token: 0x040080E0 RID: 32992
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPSOGeneratorConfigVertexInputElement> _Elements;
	}
}

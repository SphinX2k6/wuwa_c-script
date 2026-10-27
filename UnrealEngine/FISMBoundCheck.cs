using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CBB RID: 3259
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ISMBoundCheck")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FISMBoundCheck : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A4C9 RID: 42185 RVA: 0x000EA7E2 File Offset: 0x000E89E2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FISMBoundCheck._ScriptStructPtr != 0) ? FISMBoundCheck._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ISMBoundCheck", ref FISMBoundCheck._ScriptStructPtr);
		}

		// Token: 0x1700273A RID: 10042
		// (get) Token: 0x0600A4CA RID: 42186 RVA: 0x000EA808 File Offset: 0x000E8A08
		// (set) Token: 0x0600A4CB RID: 42187 RVA: 0x000EA84B File Offset: 0x000E8A4B
		public TArray<FISMBoundCheckConfig> ISMBoundCheckConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FISMBoundCheckConfig> result;
				if ((result = this._ISMBoundCheckConfig) == null)
				{
					result = (this._ISMBoundCheckConfig = new TArray<FISMBoundCheckConfig>(base.NativePtr + (IntPtr)FISMBoundCheck.__PropertyOffset_ISMBoundCheckConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ISMBoundCheckConfig.CopyAssign(value);
			}
		}

		// Token: 0x0600A4CC RID: 42188 RVA: 0x000EA859 File Offset: 0x000E8A59
		public FISMBoundCheck()
		{
		}

		// Token: 0x0600A4CD RID: 42189 RVA: 0x000EA861 File Offset: 0x000E8A61
		public FISMBoundCheck(TArray<FISMBoundCheckConfig> ISMBoundCheckConfig)
		{
			this.ISMBoundCheckConfig = ISMBoundCheckConfig;
		}

		// Token: 0x0600A4CE RID: 42190 RVA: 0x000EA870 File Offset: 0x000E8A70
		protected override IntPtr GetUStructPtr()
		{
			return FISMBoundCheck.StaticStruct();
		}

		// Token: 0x0600A4CF RID: 42191 RVA: 0x000EA87C File Offset: 0x000E8A7C
		[NullableContext(2)]
		public FISMBoundCheck(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A4D0 RID: 42192 RVA: 0x000EA886 File Offset: 0x000E8A86
		public FISMBoundCheck(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A4D1 RID: 42193 RVA: 0x000EA891 File Offset: 0x000E8A91
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FISMBoundCheck(Pointer, false, true);
		}

		// Token: 0x0600A4D2 RID: 42194 RVA: 0x000EA89B File Offset: 0x000E8A9B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FISMBoundCheck(Pointer, MemoryOwner);
		}

		// Token: 0x04005AB5 RID: 23221
		public const string __ObjectPath = "/Script/Engine.ISMBoundCheck";

		// Token: 0x04005AB6 RID: 23222
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005AB7 RID: 23223
		internal static int __PropertyOffset_ISMBoundCheckConfig;

		// Token: 0x04005AB8 RID: 23224
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FISMBoundCheckConfig> _ISMBoundCheckConfig;
	}
}

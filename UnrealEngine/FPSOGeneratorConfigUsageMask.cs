using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001054 RID: 4180
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PSOGeneratorConfigUsageMask")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FPSOGeneratorConfigUsageMask : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EDCE RID: 60878 RVA: 0x00160F8E File Offset: 0x0015F18E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPSOGeneratorConfigUsageMask._ScriptStructPtr != 0) ? FPSOGeneratorConfigUsageMask._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PSOGeneratorConfigUsageMask", ref FPSOGeneratorConfigUsageMask._ScriptStructPtr);
		}

		// Token: 0x17003991 RID: 14737
		// (get) Token: 0x0600EDCF RID: 60879 RVA: 0x00160FB4 File Offset: 0x0015F1B4
		// (set) Token: 0x0600EDD0 RID: 60880 RVA: 0x00160FF7 File Offset: 0x0015F1F7
		public TArray<FPSOGeneratorConfigUsageMaskSingle> UsageMasks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPSOGeneratorConfigUsageMaskSingle> result;
				if ((result = this._UsageMasks) == null)
				{
					result = (this._UsageMasks = new TArray<FPSOGeneratorConfigUsageMaskSingle>(base.NativePtr + (IntPtr)FPSOGeneratorConfigUsageMask.__PropertyOffset_UsageMasks, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.UsageMasks.CopyAssign(value);
			}
		}

		// Token: 0x0600EDD1 RID: 60881 RVA: 0x00161005 File Offset: 0x0015F205
		public FPSOGeneratorConfigUsageMask()
		{
		}

		// Token: 0x0600EDD2 RID: 60882 RVA: 0x0016100D File Offset: 0x0015F20D
		public FPSOGeneratorConfigUsageMask(TArray<FPSOGeneratorConfigUsageMaskSingle> UsageMasks)
		{
			this.UsageMasks = UsageMasks;
		}

		// Token: 0x0600EDD3 RID: 60883 RVA: 0x0016101C File Offset: 0x0015F21C
		protected override IntPtr GetUStructPtr()
		{
			return FPSOGeneratorConfigUsageMask.StaticStruct();
		}

		// Token: 0x0600EDD4 RID: 60884 RVA: 0x00161028 File Offset: 0x0015F228
		[NullableContext(2)]
		public FPSOGeneratorConfigUsageMask(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EDD5 RID: 60885 RVA: 0x00161032 File Offset: 0x0015F232
		public FPSOGeneratorConfigUsageMask(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EDD6 RID: 60886 RVA: 0x0016103D File Offset: 0x0015F23D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPSOGeneratorConfigUsageMask(Pointer, false, true);
		}

		// Token: 0x0600EDD7 RID: 60887 RVA: 0x00161047 File Offset: 0x0015F247
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPSOGeneratorConfigUsageMask(Pointer, MemoryOwner);
		}

		// Token: 0x040080CE RID: 32974
		public const string __ObjectPath = "/Script/Engine.PSOGeneratorConfigUsageMask";

		// Token: 0x040080CF RID: 32975
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040080D0 RID: 32976
		internal static int __PropertyOffset_UsageMasks;

		// Token: 0x040080D1 RID: 32977
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPSOGeneratorConfigUsageMaskSingle> _UsageMasks;
	}
}

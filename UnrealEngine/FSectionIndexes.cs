using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020010E1 RID: 4321
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SectionIndexes")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FSectionIndexes : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F7CA RID: 63434 RVA: 0x0016EAE4 File Offset: 0x0016CCE4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSectionIndexes._ScriptStructPtr != 0) ? FSectionIndexes._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SectionIndexes", ref FSectionIndexes._ScriptStructPtr);
		}

		// Token: 0x17003C4B RID: 15435
		// (get) Token: 0x0600F7CB RID: 63435 RVA: 0x0016EB08 File Offset: 0x0016CD08
		// (set) Token: 0x0600F7CC RID: 63436 RVA: 0x0016EB4B File Offset: 0x0016CD4B
		public TArray<int> SectionIndexes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._SectionIndexes) == null)
				{
					result = (this._SectionIndexes = new TArray<int>(base.NativePtr + (IntPtr)FSectionIndexes.__PropertyOffset_SectionIndexes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SectionIndexes.CopyAssign(value);
			}
		}

		// Token: 0x0600F7CD RID: 63437 RVA: 0x0016EB59 File Offset: 0x0016CD59
		public FSectionIndexes()
		{
		}

		// Token: 0x0600F7CE RID: 63438 RVA: 0x0016EB61 File Offset: 0x0016CD61
		public FSectionIndexes(TArray<int> SectionIndexes)
		{
			this.SectionIndexes = SectionIndexes;
		}

		// Token: 0x0600F7CF RID: 63439 RVA: 0x0016EB70 File Offset: 0x0016CD70
		protected override IntPtr GetUStructPtr()
		{
			return FSectionIndexes.StaticStruct();
		}

		// Token: 0x0600F7D0 RID: 63440 RVA: 0x0016EB7C File Offset: 0x0016CD7C
		[NullableContext(2)]
		public FSectionIndexes(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F7D1 RID: 63441 RVA: 0x0016EB86 File Offset: 0x0016CD86
		public FSectionIndexes(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F7D2 RID: 63442 RVA: 0x0016EB91 File Offset: 0x0016CD91
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSectionIndexes(Pointer, false, true);
		}

		// Token: 0x0600F7D3 RID: 63443 RVA: 0x0016EB9B File Offset: 0x0016CD9B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSectionIndexes(Pointer, MemoryOwner);
		}

		// Token: 0x040085E4 RID: 34276
		public const string __ObjectPath = "/Script/Engine.SectionIndexes";

		// Token: 0x040085E5 RID: 34277
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040085E6 RID: 34278
		internal static int __PropertyOffset_SectionIndexes;

		// Token: 0x040085E7 RID: 34279
		[Nullable(2)]
		private TArray<int> _SectionIndexes;
	}
}

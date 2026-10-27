using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011C7 RID: 4551
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.TestMapWhiteList")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FTestMapWhiteList : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010C3E RID: 68670 RVA: 0x00189FD1 File Offset: 0x001881D1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTestMapWhiteList._ScriptStructPtr != 0) ? FTestMapWhiteList._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TestMapWhiteList", ref FTestMapWhiteList._ScriptStructPtr);
		}

		// Token: 0x17004171 RID: 16753
		// (get) Token: 0x06010C3F RID: 68671 RVA: 0x00189FF5 File Offset: 0x001881F5
		// (set) Token: 0x06010C40 RID: 68672 RVA: 0x0018A005 File Offset: 0x00188205
		public unsafe bool EnableSkipCheckSpecifiedClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTestMapWhiteList.__PropertyOffset_EnableSkipCheckSpecifiedClass) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTestMapWhiteList.__PropertyOffset_EnableSkipCheckSpecifiedClass) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004172 RID: 16754
		// (get) Token: 0x06010C41 RID: 68673 RVA: 0x0018A018 File Offset: 0x00188218
		// (set) Token: 0x06010C42 RID: 68674 RVA: 0x0018A05B File Offset: 0x0018825B
		public TArray<string> SkipSpecifiedClassName
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._SkipSpecifiedClassName) == null)
				{
					result = (this._SkipSpecifiedClassName = new TArray<string>(base.NativePtr + (IntPtr)FTestMapWhiteList.__PropertyOffset_SkipSpecifiedClassName, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SkipSpecifiedClassName.CopyAssign(value);
			}
		}

		// Token: 0x06010C43 RID: 68675 RVA: 0x0018A069 File Offset: 0x00188269
		public FTestMapWhiteList()
		{
		}

		// Token: 0x06010C44 RID: 68676 RVA: 0x0018A071 File Offset: 0x00188271
		public FTestMapWhiteList(bool EnableSkipCheckSpecifiedClass, TArray<string> SkipSpecifiedClassName)
		{
			this.EnableSkipCheckSpecifiedClass = EnableSkipCheckSpecifiedClass;
			this.SkipSpecifiedClassName = SkipSpecifiedClassName;
		}

		// Token: 0x06010C45 RID: 68677 RVA: 0x0018A087 File Offset: 0x00188287
		protected override IntPtr GetUStructPtr()
		{
			return FTestMapWhiteList.StaticStruct();
		}

		// Token: 0x06010C46 RID: 68678 RVA: 0x0018A093 File Offset: 0x00188293
		[NullableContext(2)]
		public FTestMapWhiteList(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010C47 RID: 68679 RVA: 0x0018A09D File Offset: 0x0018829D
		public FTestMapWhiteList(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010C48 RID: 68680 RVA: 0x0018A0A8 File Offset: 0x001882A8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTestMapWhiteList(Pointer, false, true);
		}

		// Token: 0x06010C49 RID: 68681 RVA: 0x0018A0B2 File Offset: 0x001882B2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTestMapWhiteList(Pointer, MemoryOwner);
		}

		// Token: 0x04008F5B RID: 36699
		public const string __ObjectPath = "/Script/Engine.TestMapWhiteList";

		// Token: 0x04008F5C RID: 36700
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008F5D RID: 36701
		internal static int __PropertyOffset_EnableSkipCheckSpecifiedClass;

		// Token: 0x04008F5E RID: 36702
		internal static int __PropertyOffset_SkipSpecifiedClassName;

		// Token: 0x04008F5F RID: 36703
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _SkipSpecifiedClassName;
	}
}

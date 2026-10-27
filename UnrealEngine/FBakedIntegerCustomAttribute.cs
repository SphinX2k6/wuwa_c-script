using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200089B RID: 2203
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedIntegerCustomAttribute")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FBakedIntegerCustomAttribute : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600788A RID: 30858 RVA: 0x000AC9DA File Offset: 0x000AABDA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBakedIntegerCustomAttribute._ScriptStructPtr != 0) ? FBakedIntegerCustomAttribute._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BakedIntegerCustomAttribute", ref FBakedIntegerCustomAttribute._ScriptStructPtr);
		}

		// Token: 0x17001C78 RID: 7288
		// (get) Token: 0x0600788B RID: 30859 RVA: 0x000AC9FE File Offset: 0x000AABFE
		// (set) Token: 0x0600788C RID: 30860 RVA: 0x000ACA12 File Offset: 0x000AAC12
		public unsafe FName AttributeName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedIntegerCustomAttribute.__PropertyOffset_AttributeName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedIntegerCustomAttribute.__PropertyOffset_AttributeName) = value;
			}
		}

		// Token: 0x17001C79 RID: 7289
		// (get) Token: 0x0600788D RID: 30861 RVA: 0x000ACA28 File Offset: 0x000AAC28
		// (set) Token: 0x0600788E RID: 30862 RVA: 0x000ACA6B File Offset: 0x000AAC6B
		public FIntegralCurve IntCurve
		{
			get
			{
				base.FastCheckIsValid();
				FIntegralCurve result;
				if ((result = this._IntCurve) == null)
				{
					result = (this._IntCurve = new FIntegralCurve(base.NativePtr + (IntPtr)FBakedIntegerCustomAttribute.__PropertyOffset_IntCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FIntegralCurve.StaticStruct(), base.NativePtr + (IntPtr)FBakedIntegerCustomAttribute.__PropertyOffset_IntCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600788F RID: 30863 RVA: 0x000ACA8C File Offset: 0x000AAC8C
		public FBakedIntegerCustomAttribute()
		{
		}

		// Token: 0x06007890 RID: 30864 RVA: 0x000ACA94 File Offset: 0x000AAC94
		public FBakedIntegerCustomAttribute(FName AttributeName, FIntegralCurve IntCurve)
		{
			this.AttributeName = AttributeName;
			this.IntCurve = IntCurve;
		}

		// Token: 0x06007891 RID: 30865 RVA: 0x000ACAAA File Offset: 0x000AACAA
		protected override IntPtr GetUStructPtr()
		{
			return FBakedIntegerCustomAttribute.StaticStruct();
		}

		// Token: 0x06007892 RID: 30866 RVA: 0x000ACAB6 File Offset: 0x000AACB6
		[NullableContext(2)]
		public FBakedIntegerCustomAttribute(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007893 RID: 30867 RVA: 0x000ACAC0 File Offset: 0x000AACC0
		public FBakedIntegerCustomAttribute(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007894 RID: 30868 RVA: 0x000ACACB File Offset: 0x000AACCB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBakedIntegerCustomAttribute(Pointer, false, true);
		}

		// Token: 0x06007895 RID: 30869 RVA: 0x000ACAD5 File Offset: 0x000AACD5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBakedIntegerCustomAttribute(Pointer, MemoryOwner);
		}

		// Token: 0x040039E7 RID: 14823
		public const string __ObjectPath = "/Script/Engine.BakedIntegerCustomAttribute";

		// Token: 0x040039E8 RID: 14824
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040039E9 RID: 14825
		internal static int __PropertyOffset_AttributeName;

		// Token: 0x040039EA RID: 14826
		internal static int __PropertyOffset_IntCurve;

		// Token: 0x040039EB RID: 14827
		[Nullable(2)]
		private FIntegralCurve _IntCurve;
	}
}

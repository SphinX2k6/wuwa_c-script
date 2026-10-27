using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200266F RID: 9839
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/PropertyPath.CachedPropertyPath")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FCachedPropertyPath : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060248C7 RID: 149703 RVA: 0x00361B87 File Offset: 0x0035FD87
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCachedPropertyPath._ScriptStructPtr != 0) ? FCachedPropertyPath._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/PropertyPath.CachedPropertyPath", ref FCachedPropertyPath._ScriptStructPtr);
		}

		// Token: 0x17008CE1 RID: 36065
		// (get) Token: 0x060248C8 RID: 149704 RVA: 0x00361BAC File Offset: 0x0035FDAC
		// (set) Token: 0x060248C9 RID: 149705 RVA: 0x00361BEF File Offset: 0x0035FDEF
		public TArray<FPropertyPathSegment> Segments
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPropertyPathSegment> result;
				if ((result = this._Segments) == null)
				{
					result = (this._Segments = new TArray<FPropertyPathSegment>(base.NativePtr + (IntPtr)FCachedPropertyPath.__PropertyOffset_Segments, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Segments.CopyAssign(value);
			}
		}

		// Token: 0x17008CE2 RID: 36066
		// (get) Token: 0x060248CA RID: 149706 RVA: 0x00361BFD File Offset: 0x0035FDFD
		// (set) Token: 0x060248CB RID: 149707 RVA: 0x00361C11 File Offset: 0x0035FE11
		[Nullable(2)]
		public unsafe UFunction CachedFunction
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFunction>(base.NativePtr / (IntPtr)sizeof(void*) + FCachedPropertyPath.__PropertyOffset_CachedFunction);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FCachedPropertyPath.__PropertyOffset_CachedFunction, value);
			}
		}

		// Token: 0x060248CC RID: 149708 RVA: 0x00361C26 File Offset: 0x0035FE26
		public FCachedPropertyPath()
		{
		}

		// Token: 0x060248CD RID: 149709 RVA: 0x00361C2E File Offset: 0x0035FE2E
		public FCachedPropertyPath(TArray<FPropertyPathSegment> Segments, UFunction CachedFunction)
		{
			this.Segments = Segments;
			this.CachedFunction = CachedFunction;
		}

		// Token: 0x060248CE RID: 149710 RVA: 0x00361C44 File Offset: 0x0035FE44
		protected override IntPtr GetUStructPtr()
		{
			return FCachedPropertyPath.StaticStruct();
		}

		// Token: 0x060248CF RID: 149711 RVA: 0x00361C50 File Offset: 0x0035FE50
		[NullableContext(2)]
		public FCachedPropertyPath(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060248D0 RID: 149712 RVA: 0x00361C5A File Offset: 0x0035FE5A
		public FCachedPropertyPath(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060248D1 RID: 149713 RVA: 0x00361C65 File Offset: 0x0035FE65
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCachedPropertyPath(Pointer, false, true);
		}

		// Token: 0x060248D2 RID: 149714 RVA: 0x00361C6F File Offset: 0x0035FE6F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCachedPropertyPath(Pointer, MemoryOwner);
		}

		// Token: 0x04013A3A RID: 80442
		public const string __ObjectPath = "/Script/PropertyPath.CachedPropertyPath";

		// Token: 0x04013A3B RID: 80443
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013A3C RID: 80444
		internal static int __PropertyOffset_Segments;

		// Token: 0x04013A3D RID: 80445
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPropertyPathSegment> _Segments;

		// Token: 0x04013A3E RID: 80446
		internal static int __PropertyOffset_CachedFunction;
	}
}

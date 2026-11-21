using System;
using System.Runtime.CompilerServices;
using System.Text;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000068 RID: 104
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/CoreUObject.SoftObjectPath")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FSoftObjectPath : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06000A7E RID: 2686 RVA: 0x00011307 File Offset: 0x0000F507
		public FSoftObjectPath(string Path)
		{
			if (!string.IsNullOrEmpty(Path))
			{
				this.SetPath(Path);
			}
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0001131E File Offset: 0x0000F51E
		[NullableContext(2)]
		public FSoftObjectPath(UObject Object)
		{
			if (Object != null)
			{
				this.AssetPathName = Object.GetPathName();
			}
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x0001133A File Offset: 0x0000F53A
		public FSoftObjectPath([Nullable(2)] UObject Object, string SubPath)
		{
			if (Object != null)
			{
				this.AssetPathName = Object.GetPathName();
			}
			this.SubPathString = SubPath;
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x00011360 File Offset: 0x0000F560
		[NullableContext(2)]
		public unsafe void SetPath(string Path)
		{
			FCSharpStringView fcsharpStringView;
			if (string.IsNullOrEmpty(Path))
			{
				IntPtr nativePtr = base.NativePtr;
				fcsharpStringView = default(FCSharpStringView);
				FSoftObjectPath.Internal_SetPath(nativePtr, fcsharpStringView);
				return;
			}
			char* ptr;
			if (Path == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* ptr2 = Path.GetPinnableReference())
				{
					ptr = ptr2;
				}
			}
			char* ptr3 = ptr;
			IntPtr nativePtr2 = base.NativePtr;
			fcsharpStringView = new FCSharpStringView(ptr3, Path.Length);
			FSoftObjectPath.Internal_SetPath(nativePtr2, fcsharpStringView);
			char* ptr2 = null;
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x000113B8 File Offset: 0x0000F5B8
		public void Reset()
		{
			FSoftObjectPath.Internal_Reset(base.NativePtr);
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x000113C5 File Offset: 0x0000F5C5
		[NullableContext(2)]
		public UObject ResolveObject()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer(FSoftObjectPath.Internal_ResolveObject(base.NativePtr)) as UObject;
		}

		// Token: 0x06000A84 RID: 2692
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetPath(IntPtr This, in FCSharpStringView Path);

		// Token: 0x06000A85 RID: 2693
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Reset(IntPtr This);

		// Token: 0x06000A86 RID: 2694
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr Internal_ResolveObject(IntPtr This);

		// Token: 0x06000A87 RID: 2695 RVA: 0x000113DC File Offset: 0x0000F5DC
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder(128);
			FName assetPathName = this.AssetPathName;
			if (!assetPathName.IsNone())
			{
				stringBuilder.Append(assetPathName.ToString());
			}
			string subPathString = this.SubPathString;
			if (subPathString.Length > 0)
			{
				stringBuilder.Append(':');
				stringBuilder.Append(subPathString);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x00011440 File Offset: 0x0000F640
		public string GetAssetPathString()
		{
			FName assetPathName = this.AssetPathName;
			if (!assetPathName.IsNone())
			{
				return assetPathName.ToString();
			}
			return string.Empty;
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00011470 File Offset: 0x0000F670
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSoftObjectPath._ScriptStructPtr != 0) ? FSoftObjectPath._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.SoftObjectPath", ref FSoftObjectPath._ScriptStructPtr);
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x00011494 File Offset: 0x0000F694
		// (set) Token: 0x06000A8B RID: 2699 RVA: 0x000114A8 File Offset: 0x0000F6A8
		public unsafe FName AssetPathName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoftObjectPath.__PropertyOffset_AssetPathName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoftObjectPath.__PropertyOffset_AssetPathName) = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x000114BD File Offset: 0x0000F6BD
		// (set) Token: 0x06000A8D RID: 2701 RVA: 0x000114D1 File Offset: 0x0000F6D1
		public unsafe string SubPathString
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSoftObjectPath.__PropertyOffset_SubPathString)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSoftObjectPath.__PropertyOffset_SubPathString)), value);
			}
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x000114E6 File Offset: 0x0000F6E6
		public FSoftObjectPath()
		{
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x000114EE File Offset: 0x0000F6EE
		protected override IntPtr GetUStructPtr()
		{
			return FSoftObjectPath.StaticStruct();
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x000114FA File Offset: 0x0000F6FA
		[NullableContext(2)]
		public FSoftObjectPath(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x00011504 File Offset: 0x0000F704
		public FSoftObjectPath(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x0001150F File Offset: 0x0000F70F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSoftObjectPath(Pointer, false, true);
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00011519 File Offset: 0x0000F719
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSoftObjectPath(Pointer, MemoryOwner);
		}

		// Token: 0x04000187 RID: 391
		public const string __ObjectPath = "/Script/CoreUObject.SoftObjectPath";

		// Token: 0x04000188 RID: 392
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000189 RID: 393
		internal static int __PropertyOffset_AssetPathName;

		// Token: 0x0400018A RID: 394
		internal static int __PropertyOffset_SubPathString;
	}
}

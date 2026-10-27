using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200005D RID: 93
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public sealed class UnrealScriptStructProxyArrayProcessor<[Nullable(0)] T> : NativeArrayProcessorBase<T>, IScriptStructProcessor where T : UnrealScriptStructProxy, IUnrealScriptStructProxy, new()
	{
		// Token: 0x06000908 RID: 2312 RVA: 0x00011058 File Offset: 0x0000F258
		public UnrealScriptStructProxyArrayProcessor()
		{
			this.IsStructProxyProcessor = true;
			this.RequireConstructAndDestruct = true;
			this.HasGetTypeHash = typeof(T).IsDefined(typeof(HasGetTypeHashAttribute));
			int num;
			UnrealReflectionUtils.GetUScriptStructProps(IUnrealScriptStruct.StaticStruct(), out this.Size, out this.MinAlignment, out num);
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x000110B6 File Offset: 0x0000F2B6
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public UScriptStructStackOnlyPtr GetNativeScriptStructPtr()
		{
			return IUnrealScriptStruct.StaticStruct();
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x000110C3 File Offset: 0x0000F2C3
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override T Get(IntPtr Data, int Index)
		{
			return IUnrealScriptStructProxy.CreateFromPointer(Data + (IntPtr)(Index * this.Size)) as T;
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x000110E5 File Offset: 0x0000F2E5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override T GetRef_Unsafe(IntPtr Data, int Index, UnrealObject Caller)
		{
			return IUnrealScriptStructProxy.CreateReferenceFromPointer(Data + (IntPtr)(Index * this.Size), Caller) as T;
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x00011108 File Offset: 0x0000F308
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void Set(IntPtr Data, int Index, T Value)
		{
			SharpherealAssert.Assert(Value != null, "Struct Value is null");
			UnrealReflectionUtils.CopyNativeStruct(IUnrealScriptStruct.StaticStruct(), Data + (IntPtr)(Index * this.Size), Value._NativePtr, 1, false);
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00011148 File Offset: 0x0000F348
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int FindIndex(IntPtr Data, int Num, T Value)
		{
			SharpherealAssert.Assert(Value != null, "Struct Value is null");
			return UnrealReflectionUtils.FindNativeStructIndexInArray(IUnrealScriptStruct.StaticStruct(), Data, Value._NativePtr, Num);
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x0001117D File Offset: 0x0000F37D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void ConstructValues(IntPtr Data, int Index, int Count)
		{
			UnrealReflectionUtils.InitializeStruct(IUnrealScriptStruct.StaticStruct(), (void*)(Data + (byte*)((IntPtr)(Index * this.Size))), Count);
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0001119B File Offset: 0x0000F39B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void DestructValues(IntPtr Data, int Index, int Count)
		{
			UnrealReflectionUtils.DestroyStruct(IUnrealScriptStruct.StaticStruct(), (void*)(Data + (byte*)((IntPtr)(Index * this.Size))), Count);
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x000111B9 File Offset: 0x0000F3B9
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void CopyTo(IntPtr Data, IntPtr Dest, int Num)
		{
			UnrealReflectionUtils.CopyNativeStruct(IUnrealScriptStruct.StaticStruct(), Dest, Data, Num, true);
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x000111CF File Offset: 0x0000F3CF
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void* GetElementPtr([Nullable(1)] ref T Value, ref bool bRequireToDelete)
		{
			return Value._NativePtr;
		}
	}
}
